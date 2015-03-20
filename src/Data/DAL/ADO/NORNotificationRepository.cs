﻿using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class NORNotificationRepository : INORNotificationRepository, IDisposable
    {
        private SqlConnection connection = null;
        public List<NotRequiredOperation> GetAllNotRequiredOperation()
        {
            CreateConnection();
            List<NotRequiredOperation> inspectionOperations = new List<NotRequiredOperation>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"Select s.id, t.id, t.code,t.name,t.frequency,t.frequencyMeasure, s.type
                                                    From PipeTest t, PipeMillSizeType s 
                                                    where t.isRequired=0 and t.pipeMillSizeTypeId=s.id";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperations.Add(new NotRequiredOperation()
                        {
                            PipeSizeTypeId = (Guid)dr[0],
                            OperationId = (Guid)dr[1],
                            OperationCode=(string)dr[2],
                            OperationName = (string)dr[3],
                            Frequency = (int)dr[4],
                            Measure = (string)dr[5],// problem with convertation to enum type
                            PipeSizeTypeName = (string)dr[6]
                        });
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperations;
        }

        public List<KeyValuePair<DateTime, Guid>> GetAllNotRequiredOperationResult()
        {
            CreateConnection();
            List<KeyValuePair<DateTime, Guid>> inspectionOperationsResult = new List<KeyValuePair<DateTime, Guid>>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"Select Max(r.Date), t.id From PipeTestResult r
right join PipeTest t on r.pipeTestId=t.id where t.isRequired=0
  group by t.id";

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperationsResult.Add(new KeyValuePair<DateTime, Guid>(
                        dr[0] == System.DBNull.Value ? (DateTime)(new DateTime(1950, 6, 10, 15, 24, 16)) : (DateTime)dr[0],
                        (Guid)dr[1]
                        ));
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperationsResult;
        }

        public KeyValuePair<Guid, float> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, FrequencyMeasure measure)
        {
            CreateConnection();
            KeyValuePair<Guid, float> unitsProducedSinceLastDate = new KeyValuePair<Guid,float>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@testId", testId);
                    command.Parameters.AddWithValue("@maxDate", maxDate);

                    if (measure == FrequencyMeasure.Pipes)
                    {
                        command.CommandText = @"Select count(p.number) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]
                            );
                        }

                    }
                    else if (measure == FrequencyMeasure.Tons)
                    {
                        command.CommandText = @"Select sum(p.weight) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(double)dr[0]

                            );
                        }
                    }

                    else if (measure == FrequencyMeasure.Meters)
                    {
                        command.CommandText = @"Select sum(p.length) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]);
                        }
                    }
                    else 
                    {
                        command.CommandText = @"Select 0 amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]);
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return unitsProducedSinceLastDate;
        }

        public SqlConnection CreateConnection()
        {
            if (connection == null)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrismDatabase"];
                connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }

        public void Dispose()
        {
            try
            {
                connection.Dispose();
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Dispose", ex);
            }
        }


        public KeyValuePair<Guid, float> GetUnitsProducedSinceLastDateTest(Guid testId, FrequencyMeasure measure)
        {
            CreateConnection();
            KeyValuePair<Guid, float> unitsProducedSinceLastDate = new KeyValuePair<Guid, float>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@testId", testId);

                    if (measure == FrequencyMeasure.Pipes)
                    {
                        command.CommandText = @" Select count(p.number) amount, Max(r.date) date , t.id 
                                                            From Pipe p, PipeTest t, PipeTestResult r 
                                                            where t.pipeMillSizeTypeId=p.typeId and t.id =@testId
                                                                and p.isActive=1 and t.id=r.pipeTestId and p.productionDate>date
                                                                            group by  t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                testId,
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]
                            );
                        }

                    }
                    else if (measure == FrequencyMeasure.Tons)
                    {
                        command.CommandText = @" Select sum(p.weight) amount, Max(r.date) date , t.id 
                                                            From Pipe p, PipeTest t, PipeTestResult r 
                                                            where t.pipeMillSizeTypeId=p.typeId and t.id =@testId
                                                                and p.isActive=1 and t.id=r.pipeTestId and p.productionDate>date
                                                                            group by  t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>(

                                testId,
                                dr[0] == System.DBNull.Value ? 0 : (float)(double)dr[0]

                            );
                        }
                    }

                    else if (measure == FrequencyMeasure.Meters)
                    {
                        command.CommandText = @" Select sum(p.length) amount, Max(r.date) date , t.id 
                                                            From Pipe p, PipeTest t, PipeTestResult r 
                                                            where t.pipeMillSizeTypeId=p.typeId and t.id =@testId
                                                                and p.isActive=1 and t.id=r.pipeTestId and p.productionDate>date
                                                                            group by  t.id ";

                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                (testId,
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]);
                        }
                    }
                    else
                    {
                        command.CommandText = @" Select 0 amount, Max(r.date) date , t.id 
                                                            From Pipe p, PipeTest t, PipeTestResult r 
                                                            where t.pipeMillSizeTypeId=p.typeId and t.id =@testId
                                                                and p.isActive=1 and t.id=r.pipeTestId and p.productionDate>date
                                                                            group by  t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, float>
                                (testId,
                                dr[0] == System.DBNull.Value ? 0 : (float)(int)dr[0]);
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all units produced fr current test", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return unitsProducedSinceLastDate;
        }
    }
}
