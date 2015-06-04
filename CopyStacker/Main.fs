open System
open System.Windows.Forms

open CopyStacker
open CopyStacker.Clipboard
open CopyStacker.Windows

[<EntryPoint>]
let main argv = 
    use trayIcon = new TrayIcon()
    use form = new CopyStackerForm()

    Application.Run()
    0