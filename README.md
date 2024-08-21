# PROG6212-Group_ICE_Task

## Note:
1. You need to have Git installed.
2. You need to have .NET installed (GUI or CLI).
3. You need to have WPF installed.
4. This .NET application uses WPF, which is Windows-specific.

## Cloning the Repository
To clone the repository from GitHub to your local machine, you can use the following steps:

1. **Open a Terminal:** On you're on Windows, you can use Command Prompt or PowerShell.

2. **Navigate to the Directory:** Change to the directory where you want to clone the repository. For example, you might want to navigate to a directory where you keep your projects:
   ```bash
   cd /path/to/your/projects
   ```

3. **Clone the Repository:** Use the `git clone` command with the repository URL:
   ```bash
   git clone https://github.com/Ryan-Millard/PROG6212-Group_ICE_Task.git
   ```

4. **Navigate into the Cloned Repository:** After cloning, you can navigate into the project directory:
   ```bash
   cd PROG6212-Group_ICE_Task
   ```

This will copy the repository to your local machine, and you can start working with it. Let me know if you encounter any issues!

## Contributing to this repository
The following are the rules regarding contributions made to this repository, which explain the process that must be followed for any contributions to be added.

1. [Clone the repository to your machine](https://github.com/Ryan-Millard/PROG6212-Group_ICE_Task/edit/readme/README.md#cloning-the-repository) (see above).
2. Create a new branch with a descriptive name about the changes made to the project.
   ```bash
   git checkout -b [branchName]
   ```
3. Implement your changes.
4. Add and commit your changes.
   ```bash
   git add . && git commit -m [Brief description of your commit]
   ```
5. Push your branch to GitHub.
   ```bash
   git push -u origin [branchName]
   ```
6. Submit a [pull request](https://github.com/Ryan-Millard/PROG6212-Group_ICE_Task/pulls) and wait for the changes to be reviewed.

## Work Distribution
To divide the work effectively among the five group members, here’s a suggested task breakdown:

1. **Design and Planning ([Rahil](https://github.com/RahilSir))**
   - **Task**: Create class diagrams and design the overall architecture of the event management system.
   - **Responsibilities**:
     - Design class diagrams representing event entities, schedules, and user interactions.
     - Outline how LINQ will be used for filtering and organizing data.
     - Plan the integration of asynchronous operations and multithreading.

2. **Event Management and LINQ Implementation ([Munashe](https://github.com/mintymuna))**
   - **Task**: Develop the core event management functionality using LINQ and anonymous types.
   - **Responsibilities**:
     - Implement classes for events, schedules, and user interactions.
     - Write LINQ queries to filter and categorize events based on date, type, or department.
     - Use anonymous types to represent dynamic event details.

3. **Multithreading and Concurrency ([Areeb](https://github.com/Areeb-Ibrahim))**
   - **Task**: Implement multithreaded tasks to handle concurrent event-related operations.
   - **Responsibilities**:
     - Develop functionality for tasks such as notifying students and updating event statuses.
     - Ensure proper synchronization and handling of concurrent operations.

4. **Asynchronous Operations ([Eesan]((https://github.com/Eesan1))**
   - **Task**: Handle asynchronous programming for I/O-bound operations.
   - **Responsibilities**:
     - Implement asynchronous methods for fetching event data from external sources.
     - Integrate with calendar services or other external APIs.

5. **UI/UX and Integration ([Ryan](https://github.com/Ryan-Millard))**
   - **Task**: Develop the WPF user interface and integrate all components.
   - **Responsibilities**:
     - Design and implement the WPF interface for interacting with the event management system.
     - Ensure the UI is responsive and integrates smoothly with the backend components.
     - Conduct testing to ensure all functionalities are working as expected.
