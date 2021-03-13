const { GATEWAY, MONOLITH, MICROSERVICE } = require('./application-types');

const ApplicationOptionTypes = {
    STRING: 'string',
    INTEGER: 'integer',
    BOOLEAN: 'boolean',
    LIST: 'list',
};

const optionNames = {
    APPLICATION_TYPE: 'applicationType',
    AUTHENTICATION_TYPE: 'authenticationType',
    DEFAULT_SERVER_PORT:'serverPort',
    BASE_NAME: 'baseName',
};

const optionValues = {
    [optionNames.APPLICATION_TYPE]: {
        [MONOLITH]: MONOLITH,
        [MICROSERVICE]: MICROSERVICE,
        [GATEWAY]: GATEWAY
    },
    [optionNames.AUTHENTICATION_TYPE]: {
        jwt: 'jwt',
        rf: 'rf'
    },
    [optionNames.BASE_NAME]: 'ripster',
    [optionNames.DEFAULT_SERVER_PORT]: '5050',
     
};

const optionTypes = {
    [optionNames.APPLICATION_TYPE]: { type: ApplicationOptionTypes.STRING },
    [optionNames.AUTHENTICATION_TYPE]: { type: ApplicationOptionTypes.STRING },
    [optionNames.BASE_NAME]: { type: ApplicationOptionTypes.STRING },
};

 
module.exports = {
    OptionTypes: ApplicationOptionTypes,
    OptionNames: optionNames,
    OptionValues: optionValues,
};
 
