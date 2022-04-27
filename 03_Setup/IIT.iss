; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "IIT"
#define MyAppVersion "1.1.2(27-04-2022)"
#define MyAppPublisher "NSoftSol Pvt Ltd."
#define MyAppURL "http://www.nsoftsol.com/"
#define MyAppExeName "IIT.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{F5506600-2C08-4178-9E2A-C036BF63C331}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={win}\IIT
; DisableDirPage=yes
AlwaysShowDirOnReadyPage=yes
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=IIT
Compression=lzma
SolidCompression=yes
DisableProgramGroupPage=yes
UsePreviousTasks=Yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
source: "..\02_Code\IIT\IIT\bin\Release\*"; destdir: "{win}\IIT"; flags: ignoreversion recursesubdirs createallsubdirs; Permissions: everyone-full

[Dirs]

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{win}\IIT\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{win}\IIT\{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{win}\IIT\{#MyAppExeName}"; Tasks: desktopicon
[Run]
Filename: "{win}\IIT\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: shellexec postinstall skipifsilent