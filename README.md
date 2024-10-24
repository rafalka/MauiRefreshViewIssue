This sample project illustrates a .NET MAUI `RefreshView` issue on Android.
It occures when RefreshView is measured and lay out with different bounds, ie when it is placed inside a Grid with spans
As I checked, root cause is fact that Android `SwipeRefreshLayout.onLayout()` takes measured width/height instead of provided layout dimensions.

iOS: ![image](https://github.com/user-attachments/assets/26eb2a77-4f0e-4dd0-bac3-f54762d9ece8)
Android: ![image](https://github.com/user-attachments/assets/6188623c-b165-4fc6-8429-9653a1c4e049)

