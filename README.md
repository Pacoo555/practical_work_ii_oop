# Practical Work II

## Readme
- Added the main files for the project.
- Added the files from the past activity.
- Added MainPage.xaml and .cs
- Added RegisterPage.xaml and .cs
- Added ConversorPage.xaml and .cs
- Added UserInfoPage.xaml and .cs
- Added PrivacyPolicyPage.xaml and .cs
- Added ForgotPasswordPage.xaml and .cs


## Design Detailed Document

### Table of Contents
- [1. Introduction](#1-introduction)
- [2. Description](#2-description)
- [3. Problems](#3-problems)
- [4. Conclusions](#4-conclusion)


### 1. Introduction

This document presents a detailed description of the GUI implementation to the calculator project, developed using .NET MAUI. The document aims to provide an understanding of the decisions made during the development process and how they were implemented, while also reflecting on the challenges faced and lessons learned.


### 2. Description

#### Class Diagram

![Class Diagram](../diagramfull.png)
Here is a breakdown of the class diagram for the project, including classes all the classes from the conversor project. Because of the length of the diagram the image is a bit blurry, so I added this [link](https://kroki.io/mermaid/svg/eNrtWN1v2zYQf-9foUcZswvspQ9BFiCx0zZAmxhLtndaOsvsZNIgaSfeuv7tI6kvUjzJsp1uGFA_BBDvx_u-412SnEg5oyQTZP0m0r_EHESfCWVzkkH0lz00v592nKbRA_vEM8qmOU3-gDTmiy-QqEgCS0GMo9sdMHUtMhnBKLj4gT_xXyGjUoE45f57LjKu5lq9Zy7SoRz-fuOY9QhSUs5mRBHXMqmIokmU8yyD9DcJ4iIyf8P75tS_KCjL7DEjawgIlbIhpylnSmuK-viOUUVJTv-EKV9vONO4uO2OGZWbnOyvcxAqLqUpqnIYR-XXWtuqudffi61SnLX5zLdydS33LImtKhv9Z4RquwMhuXD09QBVXLvofuxCVJ1vk8nXK885F9odKxBUyTbwygunDVmBcY8NzEbtIvpIEBa-ZRfRPdnRjCiQkeIh2jPzEBixuXXlgIfd5Dc23LElP6Vw7thmq065OM2BnFSqpTU6CEfdpkxFH0A9bEDogtSXeQqxl75P8KI681OhxTkHseRi3agUGzG8klHXBzVeGkeGuKDqUVcfIqhWTQYxuk7Tmhr7PMsvvlW1CEe--QQhuKiB9utzUb9t5z6SHTRaVIKWNAfTgf6FnmfUvd-uH5aNFv_39lYVV1f3urG8kdwy6RjCb5kS-wFov-YPdb42-srJeqf5hTAnZ3txp3XTkI_nTaRJhjdK_xqDtTUkUTJ6pmrVgS7cG4C7U7Z0_737Qne93NjDbX6Dsh4vtbLSrFJNuQ16Q232uOdOoUzKXnvKSDVZcJ5Hd_J3XYZpZWtVZ5vyuy3KdB6j-ROfyl0FNs6ra3BberM-QFiVlFuZkE3d3Hck30JbnpkX54LuSLKfc23cfpBpiY6McsP7XrfGOvRdTco99mQ2RC88ZfnV11FAwEgn7bYqqwBd1lUiwBRLX-kJWIIAlmhUn9puDgXEeDTAHyHLtt1DRjyrQEhFUnm6IiyDYyd8N61MoG1_CChVpePUSmZD7fTMWeX-X_YoJEBYGnfA_NdhK4enqGO0nURt0yGKu-ZfXpKFNkt386sr5wkvkOCNU0ji3lBGxL6T-WA-M0jomuTnM_oILyR9LWYPiTqPDeoeO274ZxaM-6AL3W1o1w3MGgyLLEfUm8EmzgsUHKawpGbM5Kz15pWjfXPaUmXnKWsd7GwOxePWMB83-NGxF8b-muHMrNoC5a0rdmsotgcHXFVM1Q-K7hk78S94UqG2JMdQVgU5CgZVvYOZRhSjlFltjEu3zr0HSG8Ko4KJvk7T_iJ-4mUCuineIgVeDfUMfXFwX5x80u_xt8bv35odTbZjq2_Grb319oWqONxldT9egHAWthbEBhsnd-6vfDOO8Pih-ePA3Rw6vNcWHinUQL1RVZuEDRF-0bgrakUd9W3MnoZjM8aV-o-r5fiIrdisw3OiVoil7Tbj7Bimv1x-nUzaqehgTMo4_zaidmupH0PHi2_f-vvZmjCttgzkGWatFlQy_NH_fvS_79X_np65-d9LDms9-aEiccT5ku3zj0r0KedLckYTVB5GP1_qrOLoOdAtW9P1pc6Q6Jfo53cNe_xin0JF44Mi3aRfSP0lcaAUcINsfFwH-pRXdJ0TGVSeQ39FqUWRoQIL0kmyjvY39j51bzmHlpf-NWLIxnLsC9lg8BaCQv3aRyFYuaJAvJD6oVZ-P8SR3w8sXHPsQ_8dd7ShG9fR-9w_ryFuZw) of the full diagram online.

#### MainPage
This page is the login page, where the user inputs the username and password and gets access to the ConversorPage

#### RegisterPage
This page allows user to create an account. In order to do so, they must input a name, username and password. When a user is created, it is stored in a csv file called "Users.csv". Also, the user must accept the privacy policy in the checkbox made.

#### PrivacyPolicyPage
The privacy policy page shows an example of how the privacy policy should be. It can be accessed by clicking a link on the register page.

#### ConversorPage
This page is where the user can make all the operations. The user is redirected to this page after correctly logging in. In this page, there are buttons which represent numbers and letters, which let you write in a prompt. After that, the right column lets you choose the conversion you want to make. Additionally, I added a bit prompt, where the user can specify the number of bits used for the conversion. After clicking on the conversion type, the program will be executed and the solution will be prompted as an alert. Moreover, The conversion will is saved in the "output.csv" file.

#### UserInfoPage
This page can be accessed by pressing a button in the conversor page. The user info page displays the essential information of the current user: name, username, password and the number of operations.

#### ForgotPasswordPage
This page can be accessed from the main page(login). In order to change the password, the user must input the name, username and the new password.

### 3. Problems
In this project I encountered two main problems. The first one was an error on the MainPage.xaml, where the debugger said there was an error on the "<", so at first I thought I was missing something. However, this error was actually caused by the class OnForgotPasswordClicked. On the cs file I typed an uppercase that wasn't supposed to be there. So, in the end, it was just a dumb mistake.

However, I found another problem which I have not found any solution yet. After working on the project for a bit, I realized my project compiled correctly, but sometimes it would crash right after starting, and the program would exit with the code -1073740940 (0xc0000374). Without changing anything, sometimes it would start and sometimes it wouldn't. Researching online I found out that it was an error regarding memory allocation on windows, but I have not found any way of solving it.

### 4. Conclusion
Overall, this project helped me understand better how GUI elements interact in .NET MAUI and how to handle user data across different pages. I learned the importance of checking small syntax mistakes that can cause big issues, like the one with the event handler. While some technical problems like the random crash remain unresolved, the core functionality works as expected. This experience will definitely help me avoid similar issues in future projects and improve my debugging skills.