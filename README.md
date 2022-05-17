# **Index**

1. **General information about the algorithm.**
2. **Installation.**
3. **End-user Document**
4. **Test Plan**

## 1. **General information about the algorithm.**
This algorithm has the function of validating if the user's input corresponds to a valid social security number. For this, we condition the code to respond for each of the cases. First, the entry must contain nine (9) digits. These nine must be divided into three parts, separated by hyphens (-). The first part, called the area number, should consist of numbers other than 000, 666, or 900-999. The second part, known as the group number, must contain two digits between 01-99. And finally, the third part, or the serial number, must be four digits that are between 0001-9999. The algorithm will take care of validating if the input is a valid serial number.
    
## 2. **Installation.**
In order to run the algorithm, you need to have the latest version of Git Bash and the latest version of .NET downloaded to your computer. If you are working on a computer with the Windows operating system, you must also have Visual Studio downloaded, preferably the Community 2019 version and later.

**Git Bash (**[https://git-scm.com/downloads](https://git-scm.com/downloads)**)**

*Linux*

To download the most recent version in Linux, just add the command that tells us the download page to the system Terminal, depending on which Linux distribution you are using. In the case of using Ubuntu, you should write: `apt-get install git` o `add-apt-repository ppa:git-core/ppa`
     `# apt update; apt install git`

*Windows*

To download the most recent version in Windows (being version 2.36.1 as of 05/15/2022), the file is downloaded and installed on the computer. Almost all components are left with their default parameters (making sure to have Windows Explorer integration, Git Bash Here, Git GUI Here, Git LFS (Large File Support), Associate .git* configuration files with the default text editor, and Associate .sh files to be run with Bash), changing only the use of Git, which must be set to be through the Windows command line and by third-party software.

**.NET (**[https://dotnet.microsoft.com/en-us/](https://dotnet.microsoft.com/en-us/)**)**

*Linux*

To download the latest version of .NET on Linux, search for *dotnet* and enter its official link. Depending on what Linux distribution you have, you will need to choose the most recent version, depending also on what version your system is. In the case of Ubuntu, you can find out what version it has by typing `lsb_release -a` in the Terminal, which will say the version of your model. If we see that this version is compatible with .NET for Linux, we download that version (in the case of Ubuntu our version is 20.04). Following the steps that the documentation puts, we proceed to write:

`wget [https://packages.microsoft.com/config/ubuntu/21.10/packages-microsoft-prod.deb](https://packages.microsoft.com/config/ubuntu/21.10/packages-microsoft-prod.deb) -O packages-microsoft-prod.deb`

`sudo dpkg -i packages-microsoft-prod.deb`

`rm packages-microsoft-prod.deb`

inside Terminal to add the Microsoft package. You'll likely be prompted for the user's password, so it's a good idea to have it handy. When this is done, you will have to type in the Terminal:

`sudo apt-get update; \`

`sudo apt-get install -y apt-transport-https && \
sudo apt-get update && \`

`sudo apt-get install -y dotnet-sdk-6.0`

This will allow you to write basic commands and develop .NET applications from the CLI, or Command Line Interface.

You can also type in the Terminal the following commands:

`wget [https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb](https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb)`

`sudo dpkg -i packages-microsoft-prod.deb`

This is to install the Microsoft packages repository. The following commands install the Dotnet Core SDK, which is used for developing applications.

`sudo apt update`

`sudo apt install apt-transport-https`

`sudo apt install dotnet-sdk-3.1`

Now, you need to type in the Terminal the code for the .NET Runtime, which is required to run applications.

`sudo apt update`

`sudo apt install apt-transport-https`

`sudo apt install dotnet-runtime-3.1`

For more info, you can check these instructions: [https://tecadmin.net/how-to-install-net-core-on-ubuntu-20-04/](https://tecadmin.net/how-to-install-net-core-on-ubuntu-20-04/)

*Windows*

Downloading the latest version of .NET on Windows requires you to first download Visual Studio. Visual Studio Community 2022 ([https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)) is recommended. After installing it, in the Visual Studio Installer, select the .NET desktop development component in the “Workload” tab, which will allow you to develop .NET applications

**Download the repository and run the program**

*Linux*

In the Linux Terminal, type:

`git clone` 

`cd` 

`dotnet run`

*Windows*

In the Windows Command Line, type:

`git clone <>`

`cd <>`

`<>`

This way, the algorithm can be run in Visual Studio from the command line.
    
## 3. **End-user Document**
    
    Hipervínculo
    
## 4. **Test Plan**
    
    Hipervínculo