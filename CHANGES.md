
PROBLEM
1) MyEventSystem Class: MyEventSystem class is unable to find GameAnalytics required to send level start and finish events. Although the GameAnalytics unitypackage containing the script for handling events has been imported, it is not functioning as expected.
DEBUGGING STEPS
a) GameAnalytics was not properly imported as it had a com.google.external-dependency-manager as it dependency, so importing com.google.external-dependency-manager was the first step.
b) In the .asmdef file the reference to "GameAnalyticsSDK" was needed to be added.

PROBLEM
2) Performance Issues: Despite the game having minimal objects and scripts, performance issues persist on mobile devices.
DEBUGGING STEPS
a) Not completely sure as it worked fine on test device OnePlus 5 [android version]
b) As we have a simple scene reducing the Pixel Light Count to 1 should help with performance.

PROBLEM
3) Frame Rate Dependency: Controls behave inconsistently depending on the frames per second (FPS) the game is running at.
DEBUGGING STEPS
a) In BallRoller.cs physics events were under Update(), changed that to FixedUpdate()

PROBLEM
4) Git Repository: There are issues with the git repository as numerous irrelevant files are included in pushes.
DEBUGGING STEPS
a) Updated .gitignore file using https://github.com/github/gitignore/blob/main/Unity.gitignore as a reference.

PROBLEM
5) Firebase Analytics Integration: Firebase Analytics integration is missing. I need to send the same events (start, fail, and finish) tracked by Game Analytics to Firebase too. Additional docs: https://firebase.google.com/docs/analytics/unity/start
DEBUGGING STEPS
a) Added FirebaseAnalytics.unitypackage to the project
b) Created a new Unity Project in Firebase on personal id with the correct android package name
c) Added google-services.json from Firebase project to /Assets/StreamingAssets
d) Initialised an Firebase Analytics object
e) Has no complie time errors
f) Does not work, needs more run-time debugging could not proceed as I did not have Android Simulator Setup

PROBLEM
6) Level Management: Adding and managing new levels within the project is challenging.
DEBUGGING STEPS
a) Created a Singleton LevelManager Script
b) Earlier each instance of FinishTarget needed a next level variable
c) Now it just calls a singleton instance LoadNextLevel() to load the next level
d) The logic of next level is stored in LevelManager.cs
