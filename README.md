# Bank Account Project
## Overview
This exercise is designed to test your ability to create a RESTful API for managing bank accounts. You will be required to create endpoints that allow users to retrieve account information, add deposits, create withdrawals, and transfer money between accounts. You will also need to implement a process for calculating daily interest on account balances.

## Acceptance Criteria
- Create a RESTful API that allows users to:
	- Get bank account info, including current balance, transaction list, and interest earned
	- Add deposits to an account
	- Create withdrawals from an account
- Transfer money between accounts

## Extra Credit - Design Process
To implement the daily interest feature, you will need to create a function that runs on a daily basis to calculate the interest earned by each account holder. You will also need to create a database table or data model that tracks the account balance, interest rate, and date of last interest calculation. The function should calculate the interest earned since the last calculation date and update the account balance accordingly.

## Instructions
1. Clone this repository to your local machine.
2. Implement the RESTful API according to the acceptance criteria.
3. Create a data model or database table to track account balances, interest rates, and last interest calculation dates.
4. Implement the daily interest calculation process (see extra credit section above).
5. Write tests for your implementation

Notes: 
- You can modify the models/project architecture as you solve the problem to help write clean code. This solution is just a starting point.
- This exercise is not meant to be fully completed in the 2 hour limit, we are going to use this time to go as far as we can. Focus on the code quality, tests, and communication while solving the problem.

## Evaluation Criteria
- Your implementation should meet all of the acceptance criteria listed above.
- Your code should be well-organized and easy to read.
- You should use appropriate naming conventions for variables, functions, and endpoints.
- Your code should be well-documented with clear comments and/or README files.
- Your implementation should be secure and protect against common vulnerabilities such as SQL injection and cross-site scripting (XSS) attacks.

