# Peer Programming Challenges
Use this project to challenge developers with relatively real-world examples related to RESTful APIs and front-end technologies. By loading this repository via https://vscode.dev/github/heyitsgeo/peer-programming-challenges, developers can edit code in a browser without needing to install or clone anything on their machine.

## Required extensions
To make `.vue` files easier to understand, candidates may utilize Vue syntax highlighting in Visual Studio Code. [Vue](https://marketplace.visualstudio.com/items?itemName=jcbuisson.vue)

## Challenges
1. The `SubmissionsController` is missing an endpoint and there is a todo comment in it's place. Add an endpoint to resolve the todo comment.
2. The `SubmissionsService` has already implemented the method for obtaining pending submission however it is missing the actual filtering. Implement the filtering required to get the correct results from the `DbContext`.
3. The `SubmissionsController` has an action for updating a submission by Id. However, it is expecting a service method to exists on `ISubmissionsService` to get a submission by Id which has not yet been created. Create a interface for this method and it's implementation on the `SubmissionsService`.
4. Fully implement the `UpdateSubmission` method on the `SubmissionsService`.
5. In the `submissions.js` file implement the `getPendingSubmissions` to fetch data from an API endpoint and populate the data into the `submissions` variable.
6. Read over the `submissions-page.vue` component, describe one it does, explain what you would do different, do you see any potential bugs?
