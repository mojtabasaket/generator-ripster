
module.exports = {
    askForApplicationType
};

 

async function askForApplicationType() {
    if (this.existingProject) return;

    const applicationTypeChoices = [
        {
            value: 'monolith',
            name: 'Monolithic application (recommended for simple projects)',
        },
        {
            value: 'gateway',
            name: 'Gateway application',
        },
        {
            value: 'microservice',
            name: 'Microservice application',
        },
        {
            value: 'uaa',
            name: 'JHipster UAA server',
        },
    ];

    const answers = await this.prompt([
        {
            type: 'list',
            name: 'applicationType',
            message: `Which  of application would you like to create?`,
            choices: applicationTypeChoices
        },
    ]);
    this.applicationType = this.jhipsterConfig.applicationType = answers.applicationType;
}