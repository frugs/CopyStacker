namespace CopyStacker
namespace CopyStacker

open System.Drawing
open System.Windows.Forms

type TrayIcon() = 
    let notifyIcon = new NotifyIcon()
    do notifyIcon.Icon <- new Icon("icon.ico")
    do notifyIcon.Text <- "CopyStacker"
    do notifyIcon.Visible <- true
    do notifyIcon.MouseClick.Add(fun mouseEventArgs -> do Application.Exit())

    interface System.IDisposable with
        member disposable.Dispose() =
            notifyIcon.Dispose()
