# 🎲 BoardGame Library Web App
## Overview / Context
This project is part of the final evaluation of our .NET training program.
It concludes five months of lessons during which we learned how to create and secure a full web application — from the database to the user interface — using SQL Server, ADO.NET, ASP.NET (MVC), a Session Manager, and by manually building the DAL and BLL layers.

## The project
We had four days to build a web application allowing users to own, lend, and return board games, similar to [MyLudo](https://www.myludo.fr).
Each board game had to include tags to make searching and sorting easier.

## Self Evaluation 
I felt a lot of frustration regarding the short deadline: I knew, just by reading the instructions, that it would be impossible to deliver everything within the given time.
So my strategy was to focus on **quality over quantity**, and to demonstrate that I truly understood the lessons we were taught.
I preferred not to implement every feature, but everything I did implement had to be **clean, well-structured, and bug-free**.

Key points I implemented:
- Full implementation of the User and BoardGame libraries, from DB to UI
- Secure authentication and routing using the Session Manager
- Custom validators for routing and registration

## Teacher's collegue feedback
Our work was reviewed by one of the teachers’ colleagues to ensure objective evaluation.
He mentioned being impressed by the overall quality of my project, especially given the tight schedule.
He also explained that the large scope was intentional, to evaluate how we handled stress and time constraints.

Apparently, I chose a good strategy. He appreciated the personal touches I added, which were not required but showed that I both enjoyed the project and understood the concepts deeply.

To reach a perfect project, he mentioned:
- Some missing try/catch blocks (minor impact)
- A small bug in my cookie policy (consent not mandatory)
- A last-minute bug in the soft delete feature

He told me I delivered a “junior++” level project, comparable to the work of one of his own junior colleagues.
That feedback made me feel really proud.

## What I've learned from this experience
- Managing my perfectionism while still delivering quality work
- Managing stress and time pressure effectively
- Building realistic strategies that balance technical quality and user experience

## What I want to implement to push the project further
- Add friends and allow users to view each other's libraries
- Keep the previous URL when redirecting to login (improve UX)
- Allow login via email or username
- Add profile pictures
- Redirect unknown users to the registration page
- Handle reactivation of deactivated accounts when re-registering
- Check ownership in the addToLibrary route
- Display only active games in lists
- Add the ability to update the game’s state
- finish all the features

## Tech Stach

| Layer            | Technology                         |
| ---------------- | ---------------------------------- |
| **Frontend**     | ASP.NET MVC, Razor, HTML/CSS       |
| **Backend**      | C#, ADO.NET                        |
| **Database**     | SQL Server                         |
| **Architecture** | MVC + custom DAL/BLL               |
| **Security**     | Session Manager, custom validators |

## Installation and run
``` bash
# 1️⃣ Clone the repository
git clone https://github.com/your-username/BoardGameLibrary.git

# 2️⃣ Open in Visual Studio
# 3️⃣ Update connection string in appsettings.json
# 4️⃣ Run the project (F5)


```



