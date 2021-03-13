var Generator = require('yeoman-generator');
const prompts = require('./prompts');
const defaultApplicationOptions = require('../../ripster/default-application-options');

const defaultNewApplicationOptions = defaultApplicationOptions.getConfigForMonolithApplication();
// const fs = require('fs-extra');

module.exports = class extends Generator {
    
    constructor(args, opts) {
        super(args, opts);

        this.options = defaultNewApplicationOptions;
        this.existingProject = true;

        
   
    }
 
      async prompting() {
        this.answers = await this.prompt([
          {
            type: "input",
            name: "name",
            message: "Your project name?"
          }
        ]);
      }
    
      writing(){
        
          this.fs.copyTpl(
            this.templatePath('Template.Api/Controllers/WeatherForecastController.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Controllers/WeatherForecastController.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/IServiceBehavior.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/DependencyInjection/IServiceBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/ScopedBehavior.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/DependencyInjection/ScopedBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/ServiceCollection.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/DependencyInjection/ServiceCollection.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/SingletonBehavior.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/DependencyInjection/SingletonBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/TransientBehavior.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/DependencyInjection/TransientBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Extensions/ClaimsPrincipalExtensions.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/Extensions/ClaimsPrincipalExtensions.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ApiStartup.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/Infrastructure/ApiStartup.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/AutoMapperStartUp.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/Infrastructure/AutoMapperStartUp.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ConsulStartup.cs.ejs'),
            this.destinationPath(this.answers.name+'.Api/Core/Infrastructure/ConsulStartup.cs'),{
              name: this.answers.name
            }
          );
        //   this.fs.copyTpl(
        //     this.templatePath('_bower.json'),
        //     this.destinationPath('bower.json'), {
        //       name: this.answers.name
        //     }
        //   );
        //   this.fs.copy(
        //     this.templatePath('bowerrc'),
        //     this.destinationPath('.bowerrc')
        //   );
        //   this.fs.copyTpl(
        //     this.templatePath('_server.js'),
        //     this.destinationPath('server.js')
        //   );
        //   /////Routes
        //   this.fs.copy(
        //     this.templatePath('_routes/_all.js'),
        //     this.destinationPath('routes/all.js'));
    
    
        //   // Model
        //   this.fs.copy(
        //     this.templatePath('_model/_todo.js'),
        //     this.destinationPath('model/todo.js'));
    
        //   // Views
        //   this.fs.copyTpl(
        //     this.templatePath('_views/_index.ejs'),
        //     this.destinationPath('views/index.js'), {
        //       name: this.answers.name
        //     }
        //   );
    
        //   // Public/
        //   this.fs.copy(
        //     this.templatePath('_public/_css/_app.css'),
        //     this.destinationPath('public/css/app.css')
        //   );
        //   this.fs.copy(
        //     this.templatePath('_public/_js/_app.js'),
        //     this.destinationPath('public/js/app.js')
        //   );
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