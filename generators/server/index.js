var Generator = require('yeoman-generator');
const prompts = require('./prompts');
const glob = require('glob')
module.exports = class extends Generator {

    constructor(args, opts) {
        super(args, opts);



    }


    _prompting() {
        return {
            askForApplicationType: prompts.askForApplicationType,
        };
    }

    get prompting() {

        return this._prompting();
    }
 

    writing() {
        const root = this.templatePath()
        const files = glob.sync('**', { dot: true, nodir: true, cwd: root })
        for (let i in files) {
            var destinationPath = files[i].replace(/Template/g, this.ripsterConfig.name).replace('.ejs', '');
            if (files[i].split('/').length > 1) {
                destinationPath = 'src/' + destinationPath;
            }
            this.fs.copyTpl(
                this.templatePath(files[i]),
                this.destinationPath(destinationPath), {
                name: this.ripsterConfig.name
            })
        }
    }
};