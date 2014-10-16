; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Prizm Demo"
#define MyAppVersion "0.0.3.4"
#define MyAppPublisher "ISD"
#define MyAppURL "http://www.isd.dp.ua/"
#define MyAppExeName "prizm.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{005BEC4A-C754-479A-869A-B365E509EF78}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=D:\Installs\eula.txt.txt
OutputDir=D:\Inno\out
OutputBaseFilename=setup_prism
Compression=lzma
SolidCompression=yes
ShowTasksTreeLines=True
AlwaysShowDirOnReadyPage=True
PrivilegesRequired=none

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Publish\prizm.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\redistr\dotnetfx45_full_x86_x64.exe"; DestDir: "{tmp}"; DestName: "dotnetfx45_full_x86_x64"; Flags: ignoreversion nocompression

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Flags: nowait postinstall skipifsilent; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"
Filename: "{tmp}\dotnetfx45_full_x86_x64"; WorkingDir: "{tmp}"; Description: "Windows system requirments" ; StatusMsg: "Update system files"
