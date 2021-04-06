var Generator = require('yeoman-generator');
const chalk = require('chalk');
module.exports = class extends Generator {

    constructor(args, opts) {
        super(args, opts);
        this._printRipsterLogo();


    }

    _printRipsterLogo() {

        this.log('\n');
        this.log(`${chalk.green('███████╗ ')}${chalk.red('████████╗ ███████╗   ██████╗ ████████╗ ████████╗ ███████╗')}`);
        this.log(`${chalk.green('██╔═══██╗')}${chalk.red('╚══██╔══╝ ██╔═══██╗ ██╔════╝ ╚══██╔══╝ ██╔═════╝ ██╔═══██╗')}`);
        this.log(`${chalk.green('███████╔╝')}${chalk.red('   ██║    ███████╔╝ ╚█████╗     ██║    ██████╗   ███████╔╝')}`);
        this.log(`${chalk.green('██╔══██║ ')}${chalk.red('   ██║    ██╔════╝   ╚═══██╗    ██║    ██╔═══╝   ██╔══██║')}`);
        this.log(`${chalk.green('██║  ╚██╗')}${chalk.red('████████╗ ██║       ██████╔╝    ██║    ████████╗ ██║  ╚██╗')}`);
        this.log(`${chalk.green('╚═╝   ╚═╝')}${chalk.red('╚═══════╝ ╚═╝       ╚═════╝     ╚═╝    ╚═══════╝ ╚═╝   ╚═╝')}\n`);
        this.log(chalk.white.bold('                            https://www.Ripster.tech\n'));
        this.log(chalk.white('Welcome to Ripster '));
        this.log(chalk.white(`Application files will be generated in folder: ${chalk.yellow(process.cwd())}`));

        this.log(
            chalk.green(
                ' _______________________________________________________________________________________________________________\n'
            )
        );
    }

    async prompting() {
 
        await this.composeWith('ripster:server', {
            options: {
            }
        }, {
            local: require.resolve('../server')
        });
   
    }

 
    //  //async prompting() {
    //  //   this.answers = await this.prompt([
    //  //     {
    //  //       type: "confirm",
    //  //       name: "cool",
    //  //       message: "Would you like to enable the Cool feature?",
    //  // store: true
    //  //     }
    //  //   ]);
    //  // }
    //     _prompting() {
    //         return {
    //             askForApplicationType: prompts.askForApplicationType,
    //         };
    //     }

    //     get prompting() {

    //         return this._prompting();
    //     }
    //     writing() {
    //         fs.readdir("./", (err, files) => {
    //             console.log(files);
    //             //files.forEach(file => {
    //             //    console.log(file);
    //             //});
    //         });
    //         fs.outputFile("./reza/html.html", "test", 'utf8');
    //       this.log("cool feature", this.options.applicationType); // user answer `cool` used//this.log("cool feature", this.answers.cool); // user answer `cool` used
    //   }
};