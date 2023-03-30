# Unity WebGL Build On GitHub

We need a web site to put our Unity projects, so we can play them via the web browser

1. Create a [GitHub account](https://github.com/)

2. Download [Github Desktop](https://desktop.github.com/)
   You can use command line for GitHub, but the graphical desktop is easier to use

3. Create a new public repository. Let's call it FirstGit

4. Follow the instructions on [https://pages.github.com/](https://pages.github.com/)
   to create a "Project Site" (not a User or Organizational Site).
   The Github Pages in Settings should be set to "master folder"

5. Use GitHub Desktop clone the new repository you created.
   This will copy all the files from GitHub to your local computer, creating an empty directory/

6. Create a Unity project. Let's call this project "First".

- Set Edit > Project Settings > Editor > Version Control > Visible Meta Files
- Set Edit > Project Settings > Editor > Asset Serialization > Force Text

6. Create a webGL build for your Unity project. File > Build Settings > WebGL > Build
   Move the folder to be inside your FirstGit repository

7. Commit and Push the files from your local computer to GitHub using Github Desktop

8. Check that your project can be played on the web. The URL will be something like [https://pisan385.github.io/FirstGit/firstwebgl](https://pisan385.github.io/FirstGit/firstwebgl/)

9. To test your project locally, you can start a local web server using "python3 -m http.server 7800" and then visit http://localhost:7800/ to see the local files

10. You might need to enable "Decompression Fallback" under Build Settings > Player Settings > Publishing Settings

# Unity Project on GitHub

If you will also store your source files for your Unity project on GitHub,
you shoud use a `.gitignore` file (the name is dot gitignore) tells GitHub
not to upload some unnecessary files. C

Create this file using the web interface, and place the contents
from [here](https://github.com/github/gitignore/blob/master/Unity.gitignore).
Having a `.gitignore` reduced the number of files from 1707 to 33 for me!

Do not use a `.gitignore` file for the repository that will have your webgl
builds since the defualt `.gitignore` file prevents uploading "Build" directory
which is needed
