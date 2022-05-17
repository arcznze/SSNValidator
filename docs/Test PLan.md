# **End-user Document**

This algorithm has the function of validating if the user's input corresponds to a valid social security number. For this, we condition the code to respond for each of the cases. First, the entry must contain nine (9) digits. These nine must be divided into three parts, separated by hyphens (-). The first part, called the area number, should consist of numbers other than 000, 666, or 900-999. The second part, known as the group number, must contain two digits between 01-99. And finally, the third part, or the serial number, must be four digits that are between 0001-9999. The algorithm will take care of validating if the input is a valid serial number.

---
## *Requirements*
---
<details>
  <summary>Functional Requirements</summary>

- The algorithm must not allow the input of any character type (a, b, c, @, #, ...).
- The algorithm must identify the number and position of the hyphens.
- The algorithm must indicate if the entire character string is composed only of numbers.
- The algorithm must split the string into three parts.
- The algorithm must indicate if the first part matches the criteria that must be met for it to be a valid SSN.
- The algorithm must indicate if the second part matches the criteria that must be met for it to be a valid SSN.
- The algorithm must indicate if the third party matches the criteria that must be met for it to be a valid SSN.
- The algorithm must indicate whether the given string is a valid SSN.
</details>

<details>
  <summary>Non-functional Requirements</summary>

- The algorithm is going to be executed in a console application in C#.
- The response time between the user input and the algorithm must be less than 5 seconds.
- The language of the algorithm will be English.
- The language of the console application will be English.
</details>

---
## *Criteria of acceptance*
---
- The user can enter numbers and hyphens (-), and the algorithm validates if it meets the conditions to be a valid SSN.
- The user receives a verification message if the given string is a valid SSN.
- The user receives a denial message if they do not enter a string that contains only numbers and hyphens (-).
- The user receives a denial message if they enter any type of character (other than hyphens).
- The user receives a denial message if he enters a string less than and greater than 9.
- The user receives a denial message if the entered string has more than three (3) hyphens (-).
- The user receives a deny message if the first part of the string does not have 3 digits.
- The user receives a deny message if the second part of the string does not have 3 digits.
- The user receives a deny message if the third part of the string does not have 3 digits.
- The user receives a deny message if the first part of the string does not have 3 digits.
- The user receives a denial message if the digits in each part of the string do not meet the conditions to be a valid SSN.

Note: denial message means that it does not comply with what was agreed to be considered a valid SSN.

---
## *Test cases*
---
<details>
  <summary> <span style='font-weight:bold;'><span style='color:#FFFFFF;'>End-To-End</span></span> </summary>

1. **User Functions**
    1. *If the user inserts numbers and hyphens*
        - Start the program.
        - Insert a string that contains numbers and hyphens only, divided into three parts: the first with three digits that are not 000, 666, or 900-999, the second with two digits between 01-99, and the third with four digits between 0001-9999.
        - See string validation.
        - Exit the program.
2. **Conditions**
    1. *If the user enters characters other than hyphens*
        - Start the program.
        - Enters a string that contains numbers, hyphens, and other types of characters.
        - Receive denial message.
        - Exit the program.
    2. *If the user enters a string less than or greater than 9.*
        - Start the program.
        - Enters a string less than or greater than 9.
        - Receive denial message.
        - Exit the program.
    3. *If the user enters a string that has more than three (3) hyphens (-).*
        - Start the program.
        -  Enters a string that has more than three (3) hyphens (-).
        - Receive denial message.
        - Exit the program.
    4. *If the first part of the string does not have 3 digits.*
        - Start the program.
        - Enters a string in which the first part of the string does not have 3 digits.
        - Receive denial message.
        - Exit the program.
    5. *If the second part of the string does not have 2 digits.*
        - Start the program.
        - Enters a string in which the second part of the string does not have 2 digits.
        - Receive denial message.
        - Exit the program.
    6. *If the third part of the string does not have 4 digits.*
        - Start the program.
        - Enters a string in which the third part of the string does not have 4 digits.
        - Receive denial message.
        - Exit the program.
    7. *If the digits in each part of the string do not meet the conditions to be a valid SSN.*
        - Start the program.
        - Enters a string in which the digits in each part of the string do not meet the conditions to be a valid SSN.
        - Receive denial message.
        - Exit the program.
3. **Test Cases**
    1. *User Functions 1.0*
        - The user starts the program.
        - Enters the string “203-56-8956”.
        - They receive the message “It’s a valid SSN”.
        - Exit the program.
    2. *Conditions 1.0*
        - The user starts the program.
        - Enters the string “20@-56-8#56”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    3. *Conditions 2.0*
        - The user starts the program.
        - Enters the string “125-45-8956785”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    4. *Conditions 3.0*
        - The user starts the program.
        - Enters the string “125-56-25-784-5”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    5. *Conditions 4.0*
        - The user starts the program.
        - Enters the string “12556-25-7845”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    6. *Conditions 5.0*
        - The user starts the program.
        - Enters the string “125-24585-7845”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    7. *Conditions 6.0*
        - The user starts the program.
        - Enters the string “125-25-7”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
    8. *Conditions 7.0*
        - The user starts the program.
        - Enters the string “000-00-0000”.
        - They receive the message “Is not a valid SSN”.
        - Exit the program.
</details>

<details>
  <summary> <span style='font-weight:bold;'><span style='color:#FFFFFF;'>Unit</span></span> </summary>

1. **White box**
    1. *Validation of the correct size.*
        - This method, apart from starting the program, what it does is that it calculates the number of hyphens (-) there are, and takes note of the elements that are found before it, saving them in an array. Then, confirm that the size of these are 3, 2, and 4, respectively, since it is the size that these parts must have to be a valid SSN.
    2. *Method to save each digit into an array.*
        - This method should store each element of the string within a position in the array. Depending on the length of the string, each element of the string will be stored in the array, starting from position zero (0). The limit of the array must be 3 digits since it only stores the elements from the first part of the string.
    3. *Data validation method.*
        - What this method does is that it makes sure that all elements, except hyphens, are entirely numbers. After this, validate that, in the first part of the string, the numbers 000, 666, and 900-999 are not found, in the second only numbers between 01-99, and in the third and last only numbers between 0001-9999

2. **Low level**
    1. *Validation of the correct size.*
        - Input: “1245-02-895”
        - Output expected: Invalid.
    2. *Method to save each digit into an array.*
        - Input: “458-75-3245”
        - Output expected: array[4,5,8]
    3. *Data validation method.*
        - Input: “999-45-5246”
        - Output expected: Invalid.
</details>