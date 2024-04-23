
## Need to download and import the FirebaseAnalytics.unitypackage into Assets for code to work, could not upload large file to github
1) Download the unity package https://firebase.google.com/download/unity and import it into the project for the Firebase Analytics to work.


## PROBLEM
1) MyEventSystem Class: MyEventSystem class is unable to find GameAnalytics required to send level start and finish events. Although the GameAnalytics unitypackage containing the script for handling events has been imported, it is not functioning as expected.
## DEBUGGING STEPS
1) GameAnalytics was not properly imported as it had a com.google.external-dependency-manager as it dependency, so importing com.google.external-dependency-manager was the first step.
2) In the .asmdef file the reference to "GameAnalyticsSDK" was needed to be added.

## PROBLEM
2) Performance Issues: Despite the game having minimal objects and scripts, performance issues persist on mobile devices.
## DEBUGGING STEPS
1) Not completely sure as it worked fine on test device OnePlus 5 [android version]
2) As we have a simple scene reducing the Pixel Light Count to 1 should help with performance.

## PROBLEM
3) Frame Rate Dependency: Controls behave inconsistently depending on the frames per second (FPS) the game is running at.
## DEBUGGING STEPS
1) In BallRoller.cs physics events were under Update(), changed that to FixedUpdate()

## PROBLEM
4) Git Repository: There are issues with the git repository as numerous irrelevant files are included in pushes.
## DEBUGGING STEPS
1) Updated .gitignore file using https://github.com/github/gitignore/blob/main/Unity.gitignore as a reference.

## PROBLEM
5) Firebase Analytics Integration: Firebase Analytics integration is missing. I need to send the same events (start, fail, and finish) tracked by Game Analytics to Firebase too. Additional docs: https://firebase.google.com/docs/analytics/unity/start
## DEBUGGING STEPS
1) Added FirebaseAnalytics.unitypackage to the project
2) Created a new Unity Project in Firebase on personal id with the correct android package name
3) Added google-services.json from Firebase project to /Assets/StreamingAssets
4) Initialised an Firebase Analytics object
5) Has no complie time errors
6) Does not work, needs more run-time debugging could not proceed as I did not have Android Simulator Setup

## PROBLEM
6) Level Management: Adding and managing new levels within the project is challenging.
## DEBUGGING STEPS
1) Created a Singleton LevelManager Script
2) Earlier each instance of FinishTarget needed a next level variable
3) Now it just calls a singleton instance LoadNextLevel() to load the next level
4) The logic of next level is stored in LevelManager.cs
