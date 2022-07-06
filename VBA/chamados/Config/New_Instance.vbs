Set WshShell = CreateObject("WScript.Shell")
WshShell.Run chr(34) & "\\192.168.0.3\departamentos$\ti\Inventario\Config\New_Instance.bat" & Chr(34), 0
Set WshShell = Nothing