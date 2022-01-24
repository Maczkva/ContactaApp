#define MyAppName "ContactsApp"
#define MyAppVersion "1.0.0"
#define MyAppExeName "ContactsApp.exe"

[Setup]
AppId={{6A6ADD1-A525-50SE-ACA0-9E3A684F0BFA}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputBaseFilename=ContactsAppSetup
OutputDir="installers"
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\*.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon                                                  

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
