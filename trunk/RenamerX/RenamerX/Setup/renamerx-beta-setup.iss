#include "scripts\products.iss"

#include "scripts\products\winversion.iss"
#include "scripts\products\fileversion.iss"
//#include "scripts\products\iis.iss"
//#include "scripts\products\kb835732.iss"

#include "scripts\products\msi20.iss"
#include "scripts\products\msi31.iss"
//#include "scripts\products\ie6.iss"

//#include "scripts\products\dotnetfx11.iss"
//#include "scripts\products\dotnetfx11lp.iss"
//#include "scripts\products\dotnetfx11sp1.iss"

//#include "scripts\products\dotnetfx20.iss"
//#include "scripts\products\dotnetfx20lp.iss"
//#include "scripts\products\dotnetfx20sp1.iss"
//#include "scripts\products\dotnetfx20sp1lp.iss"

#include "scripts\products\dotnetfx35.iss"
//#include "scripts\products\dotnetfx35lp.iss"
#include "scripts\products\dotnetfx35sp1.iss"
//#include "scripts\products\dotnetfx35sp1lp.iss"

//#include "scripts\products\mdac28.iss"
//#include "scripts\products\jet4sp8.iss"

#define SimpleVersion(str S) \
	Local[0] = Pos (".0.0.", S), \
	/* (4) and (5) */ \
	(Local[0] > 0) ? Copy (S, 1, 3) : \
	( \
		Local[0] = Pos (".0.0", S), \
		/* (3) */ \
		(Local[0] > 0) ? Copy (S, 1, 3) : \
		( \
			Local[0] = Pos (".0", S), \
			/* (2) */ \
			(Local[0] > 5) ? Copy (S, 1, Local[0] - 1) : \
			( \
				Local[0] = Pos (".0.", S), \
				/* (6) */ \
				(Local[0] > 0) ? Copy (S, 1, 3) : \
				( \
					Copy (S, 1, 5) \
				) \
			) \
		) \
	);
		
#define ExeName "RenamerX"		
#define ExePath "..\bin\Release\RenamerX.exe"
#define MyAppVersion GetFileVersion(ExePath)
#define MySimpleAppVersion SimpleVersion(MyAppVersion)

[CustomMessages]
win2000sp3_title=Windows 2000 Service Pack 3
winxpsp2_title=Windows XP Service Pack 2


[Setup]
AppMutex=96c417f0-c3ee-4658-917d-b8f4d7842369
AppName={#ExeName}
AppVerName={#ExeName} {#MyAppVersion}
AppVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
VersionInfoTextVersion={#MyAppVersion}
VersionInfoCompany={#ExeName}
VersionInfoDescription={#ExeName}
AppPublisher=RenamerX
AppPublisherURL=http://code.google.com/p/RenamerX
AppSupportURL=http://code.google.com/p/RenamerX/issues/list
AppUpdatesURL=http://code.google.com/p/RenamerX/downloads/list
DefaultDirName={pf}\RenamerX
DefaultGroupName={#ExeName}
;SetupIconFile=..\Resources\zss-main.ico
UninstallDisplayIcon={app}\RenamerX.exe
AllowNoIcons=yes
InfoBeforeFile=..\Docs\VersionHistory.txt
InfoAfterFile=..\Docs\license.txt
SolidCompression=yes
OutputDir=..\..\..\Output\
OutputBaseFilename={#ExeName}-{#MyAppVersion}-setup
ArchitecturesInstallIn64BitMode=x64 ia64
DirExistsWarning=no
CreateAppDir=true
UsePreviousGroup=yes
UsePreviousAppDir=yes
ShowUndisplayableLanguages=no
LanguageDetectionMethod=uilanguage
InternalCompressLevel=ultra64
Compression=lzma

;required by products
MinVersion=4.1,5.0
PrivilegesRequired=admin
;ArchitecturesAllowed=x86

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: {#ExePath}; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\{#ExeName}"; Filename: "{app}\RenamerX.exe"
;Name: "{group}\RenamerX Manual"; Filename: "{app}\RenamerX-manual.pdf"
Name: "{userdesktop}\{#ExeName}"; Filename: "{app}\RenamerX.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\RenamerX"; Filename: "{app}\RenamerX.exe."; Tasks: quicklaunchicon
Name: "{group}\Uninstall {#ExeName}"; Filename: "{uninstallexe}"

[Run]
Filename: "{app}\RenamerX.exe."; Description: "{cm:LaunchProgram,RenamerX}"; Flags: nowait postinstall skipifsilent
;Filename: "{app}\RenamerX-manual.pdf"; Description: "{cm:LaunchProgram,RenamerX Manual}"; Flags: nowait unchecked postinstall shellexec skipifsilent

[Code]
function InitializeSetup(): Boolean;
var
          ResultCode: Integer;
begin
	
	//Simple hack to remove old NSIS-installed RenamerX (v1.3.3.0 or earlier)
	if FileExists(ExpandConstant('c:\program files\RenamerX\uninst.exe')) then
  begin

        begin
          if Exec(ExpandConstant('c:\program files\RenamerX\uninst.exe'), '', '', SW_SHOW,
            ewWaitUntilTerminated, ResultCode) then
          begin
            // success
          end
          else begin
            // failure
          end;
        end;

  end;

  initwinversion();

	if (not minspversion(5, 0, 3)) then begin
		MsgBox(FmtMessage(CustomMessage('depinstall_missing'), [CustomMessage('win2000sp3_title')]), mbError, MB_OK);
		exit;
	end;
	if (not minspversion(5, 1, 2)) then begin
		MsgBox(FmtMessage(CustomMessage('depinstall_missing'), [CustomMessage('winxpsp2_title')]), mbError, MB_OK);
		exit;
	end;
	
	//if (not iis()) then exit;
	
	msi20('2.0');
	msi31('3.1');
//	ie6('5.0.2919');
	
	//dotnetfx11();
	//dotnetfx11lp();
	//dotnetfx11sp1();
	
//	kb835732();
	
//	if (minwinversion(5, 0) and minspversion(5, 0, 4)) then begin
//		dotnetfx20sp1();
//		dotnetfx20sp1lp();
//	end else begin
//		dotnetfx20();
//		dotnetfx20lp();
//	end;
	
dotnetfx35();
	//dotnetfx35lp();
	//dotnetfx35sp1();
	//dotnetfx35sp1lp();
	
//	mdac28('2.7');
//	jet4sp8('4.0.8015');
	
	Result := true;
end;
