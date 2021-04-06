
module.exports = {
    askForApplicationType
};



async function askForApplicationType() {
    if (this.existingProject) return;

    const applicationTypeChoices = [
        {
            name: 'Monolithic application',
            value: 'monolithic'
        },
        {
            name: 'Microservice application',
            value: 'microservice-application'
        },
        {
            name: 'Microservice gateway',
            value: 'microservice-gateway'
        }
    ];

     await this.prompt([
        {
            type: 'list',
            name: 'applicationType',
            message: 'Which type of application would you like to create?',
            choices: applicationTypeChoices
        },
        {
            type: "input",
            name: "name",
            message: "Your project name?"
        }
    ]).then(function (responses) {
        this.ripsterConfig = Object.assign({}, this.ripsterConfig, this.options, responses);
 
    }.bind(this));
}