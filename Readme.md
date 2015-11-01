VS13.WinForms
Overview
Development components and design mechanisms for WinForms development using Visual Studio 2013.


Projects
VS13.Reminders.Lib, VS13.Reminders.Win
Outlook-style item reminders for WinForms applications.


VS13.TrayIcon.Lib, VS13.TrayIcon.Win
Icons in the notification area are shortcuts to processes that are running in the background of a computer, such as a virus 
protection program, a volume control, or an email application like Outlook. These processes may not come with their own 
user interfaces (i.e. Windows Services). The NotifyIcon class provides a way to program in this functionality. The Icon property 
defines the icon that appears in the notification area. Pop-up menus for an icon are addressed with the ContextMenu property. The 
Text property assigns ToolTip text.

The TrayIcon class is a wrapper for the System.Windows.Forms.NotifyIcon class. It provides basic Outlook-style 
tray icon features like hide the application to the task tray when minimized and display balloon notifications of important events.
VS13.TrayIcon.Win is a sample WinForms application that shows how to use the VS13.Windows.TrayIcon class.



VS13.Windows.Lib, VS13.Windows.Win
Desktop applications use many common items such as splash screens, about dialogs, login dialogs, etc. Applications developed
for a company would like to keep consistency between applications regarding these application items. VS13.Windows.Lib is a 
collection of general items for WinForms development. VS13.Windows.Win is a sample WinForms application that shows how to use 
the VS13.Windows.Lib classes.

