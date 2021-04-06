const { OptionNames, OptionValues } = require('./application-options');
const { MONOLITH, MICROSERVICE, GATEWAY } = require('./application-types');


module.exports = {
    getConfigForMonolithApplication,
    getConfigForGatewayApplication,
    getConfigForMicroserviceApplication,
    getDefaultConfigForNewApplication,
    getConfigForApplicationType,
};


const {
    APPLICATION_TYPE,
    AUTHENTICATION_TYPE,
    DEFAULT_SERVER_PORT,
    BASE_NAME
} = OptionNames;

function getConfigForApplicationType(applicationType = undefined, customOptions = {}) {
    if (applicationType === MONOLITH) {
        return getConfigForMonolithApplication(customOptions);
    }
    if (applicationType === GATEWAY) {
        return getConfigForGatewayApplication(customOptions);
    }
    if (applicationType === MICROSERVICE) {
        return getConfigForMicroserviceApplication(customOptions);
    }
    return getDefaultConfigForNewApplication(customOptions);
}

function getConfigForMonolithApplication(customOptions = {}) {
    const options = {
        [AUTHENTICATION_TYPE]: OptionValues[AUTHENTICATION_TYPE].jwt,
        ...customOptions,
    };
 

    return {
        ...options,
        [APPLICATION_TYPE]: MONOLITH,
    };
}

function getConfigForGatewayApplication(customOptions = {}) {
    const options = {
        [AUTHENTICATION_TYPE]: OptionValues[AUTHENTICATION_TYPE].jwt,
        ...customOptions,
    };
    return {
        ...options,
        [APPLICATION_TYPE]: GATEWAY,
    };
}

function getConfigForMicroserviceApplication(customOptions = {}) {
    const options = {
        [AUTHENTICATION_TYPE]: OptionValues[AUTHENTICATION_TYPE].jwt,
        [SERVER_PORT]: OptionValues[DEFAULT_SERVER_PORT],
 
    };
 
    return {
        ...options,
        [APPLICATION_TYPE]: MICROSERVICE,
    };
}

 
function getDefaultConfigForNewApplication(customOptions = {}) {
    const options = {
        [BASE_NAME]: OptionValues[BASE_NAME],
        [APPLICATION_TYPE]: MONOLITH,
        ...customOptions,
    };
 
    return options;
}