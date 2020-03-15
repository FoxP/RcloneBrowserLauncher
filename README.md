# RcloneBrowserLauncher

## About
Launcher for [Rclone Browser](https://github.com/kapitainsky/RcloneBrowser) (from [kapitainsky](https://github.com/kapitainsky)) allowing you to :
- Start `Rclone Browser` with `RCLONE_CONFIG_PASS` [environment variable](https://rclone.org/docs/#other-environment-variables) set with your `rclone.conf` password
- Shutdown, hibernate, or sleep your computer at the end of a `Rclone Browser` tasks queue

## Usage
1. Download and run `RcloneBrowserLauncher` [latest release](https://github.com/FoxP/RcloneBrowserLauncher/releases/latest)  

![](RcloneBrowserLauncher/resources/pictures/demo_1.PNG)  

2. Select your `RcloneBrowser.exe` location
	- If installed for `All users` : `C:\Program Files\Rclone Browser\RcloneBrowser.exe`
	- If installed only for yourself : `C:\Users\%USERNAME%\AppData\Local\Programs\Rclone Browser\RcloneBrowser.exe`
3. Enter your `rclone.conf` password (**optional**)
	- :warning: Do it at your own risk, only enter your `rclone.conf` password in a safe environment
4. Select an action to be performed at the end of a `Rclone Browser` tasks queue (**optional**) :
	- Hibernate computer
	- Shutdown computer
	- Sleep computer
5. Click on the `Run Rclone Browser` button
6. Select `RcloneBrowserLauncher.exe` as finishing queue script in `RcloneBrowser`
	- This step need to be done only once  

![](RcloneBrowserLauncher/resources/pictures/demo_2.PNG)  

7. Don't forget to check `Run script when finished` option in `Rclone Browser`  

![](RcloneBrowserLauncher/resources/pictures/demo_3.PNG)  

## Advanced

Configuration file (including your `rclone.conf` password) is stored in following location :
- `C:\Users\%USERNAME%\AppData\Local\RcloneBrowserLauncher`

## Requirements
- Microsoft [.NET Framework 4](https://www.microsoft.com/en-US/download/details.aspx?id=17851)
- Microsoft Windows Vista or later
- [Rclone Browser](https://github.com/kapitainsky/RcloneBrowser) 1.9.6 or later

## Libraries
- App icon from [rclone](https://github.com/rclone/rclone)

## License
RcloneBrowserLauncher is released under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.fr.html).
