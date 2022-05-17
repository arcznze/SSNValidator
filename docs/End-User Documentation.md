# **Index**

1. Introduction
2. Algorithm Installation
3. System Overview Diagram
4. Particular Methods Defined
5. Introduction to the use of the algorithm

## **1. Introduction**

This algorithm has the function of validating if the user's input corresponds to a valid social security number. For this, we condition the code to respond for each of the cases. First, the entry must contain nine (9) digits. These nine must be divided into three parts, separated by hyphens (-). The first part, called the area number, should consist of numbers other than 000, 666, or 900-999. The second part, known as the group number, must contain two digits between 01-99. And finally, the third part, or the serial number, must be four digits that are between 0001-9999. The algorithm will take care of validating if the input is a valid serial number.

## **2. Algorithm Installation**

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

`git clone https://github.com/arcznze/SSNValidator.git` 

`cd` 

`dotnet run`

*Windows*

In the Windows Command Line, type:

`git clone https://github.com/arcznze/SSNValidator.git`

`cd <>`

`<>`

This way, the algorithm can be run in Visual Studio from the command line.

## **3. System Overview Diagram**

The algorithm performs certain actions, depending on what the user inputs. Among these options is evaluating whether the entered text string is long enough to be considered a valid social security number. From there, you will review the conditions that must be met to be considered a valid social security number. The following diagram will explain it in detail:

![System Overview Diagram](Blank diagram (1).png)

## **4. Particular Methods Defined**

Among the detailed actions that the algorithm does, there are: to evaluate if the entered text string is the size that the SSN should be, evaluate if the string contains hyphens (-), save each digit inside an array, and validate if the string is made up of numbers only, make sure that the first values are not 000, 666, or 900-999, and check that the numbers in the second and third parts are not 00 and 0000, respectively. The following diagram will explain it in detail:

## **5. Introduction to the use of the algorithm**

To use the social security number validation algorithm, all you have to do is enter a line of text in Terminal after the system prompts you to do so. The text line can contain any number and character since the purpose is to know if said entry can be a valid social number. Then, it would be to wait for the program to evaluate, using the methods that were previously reviewed. Depending on what you typed, the algorithm will tell you if it is valid or not, and in some cases, it will tell you the reason why.

In case the text string turns out to be invalid, you can try running the program again.
