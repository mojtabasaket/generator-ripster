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
            message: "Your project name12?"
          }
        ]);
      }
    
      writing(){

        this.fs.copyTpl(
          this.templatePath('Template.sln.ejs'),
          this.destinationPath(this.answers.name+'.sln'),{
            name: this.answers.name
          }
        );

      
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/IServiceBehavior.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/DependencyInjection/IServiceBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/ScopedBehavior.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/DependencyInjection/ScopedBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/ServiceCollection.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/DependencyInjection/ServiceCollection.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/SingletonBehavior.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/DependencyInjection/SingletonBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/DependencyInjection/TransientBehavior.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/DependencyInjection/TransientBehavior.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Extensions/ClaimsPrincipalExtensions.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Extensions/ClaimsPrincipalExtensions.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ApiStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/ApiStartup.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/AutoMapperStartUp.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/AutoMapperStartUp.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ConsulStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/ConsulStartup.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/DatabaseStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/DatabaseStartup.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/MediatRStartUp.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/MediatRStartUp.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ProjectStartUp.cs.ejs'),
            this.destinationPath('src/'+`${this.answers.name +'.Api/Core/Infrastructure/'+this.answers.name+'StartUp.cs'}`),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/ProblemDetailsStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/ProblemDetailsStartup.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/SecurityStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/SecurityStartup.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Infrastructure/SwaggerStartup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Infrastructure/SwaggerStartup.cs'),{
              name: this.answers.name
            }
          );
           

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Pagination/PageableBinder.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Pagination/PageableBinder.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Pagination/PageableBinderProvider.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Pagination/PageableBinderProvider.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Core/Pagination/QueryStringExtensions.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Core/Pagination/QueryStringExtensions.cs'),{
              name: this.answers.name
            }
          );
          
          this.fs.copyTpl(
            this.templatePath('Template.Api/Properties/launchSettings.json.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Properties/launchSettings.json'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Security/CustomClaims.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Security/CustomClaims.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Security/CustomClaims.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Security/CustomClaims.cs'),{
              name: this.answers.name
            }
          );


          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Extensions/ActionResultExtensions.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Extensions/ActionResultExtensions.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Extensions/ActionResultWithHeaders.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Extensions/ActionResultWithHeaders.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Extensions/HttpRequestExtensions.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Extensions/HttpRequestExtensions.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Extensions/LanguageRouteConstraint.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Extensions/LanguageRouteConstraint.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Extensions/RouteDataRequestCultureProviderExtension.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Extensions/RouteDataRequestCultureProviderExtension.cs'),{
              name: this.answers.name
            }
          );
          
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Middleware/RequestResponseLoggingMiddleware.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Middleware/RequestResponseLoggingMiddleware.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Utilities/ActionResultUtil.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Utilities/ActionResultUtil.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Utilities/HeaderUtil.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Utilities/HeaderUtil.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/web/Utilities/PaginationUtil.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/web/Utilities/PaginationUtil.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/appsettings.Development.json.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/appsettings.Development.json'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/appsettings.Production.json.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/appsettings.Production.json'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/appsettings.json.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/appsettings.json'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Program.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Program.cs'),{
              name: this.answers.name
            }
          );
          this.fs.copyTpl(
            this.templatePath('Template.Api/Startup.cs.ejs'),
            this.destinationPath('src/'+this.answers.name+'.Api/Startup.cs'),{
              name: this.answers.name
            }
          );

          this.fs.copyTpl(
            this.templatePath('Template.Api/Template.api.csproj.ejs'),
            this.destinationPath('src/'+`${this.answers.name +'.Api/'+this.answers.name+'.api.csproj'}`),{
              name: this.answers.name
            }
          );
    }


    writingCommon(){
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/AttributesUtils.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/AttributesUtils.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/Autowired.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/Autowired.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/Bean.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/Bean.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/HostEnvironment.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/HostEnvironment.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/Logger.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/Logger.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/MyStringLengthAttribute.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/MyStringLengthAttribute.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/Qualifier.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/Qualifier.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Attributes/Scope.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Attributes/Scope.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Boot/Ansi/AnsiColor.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Boot/Ansi/AnsiColor.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Boot/BannerPrinter.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Boot/BannerPrinter.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Config/AppSettings.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Config/AppSettings.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Enums/HostEnvironment.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Config/HostEnvironment.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Enums/ServiceLifetime.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Config/ServiceLifetime.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Binders/PageableBinderConfig.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Binders/PageableBinderConfig.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Extensions/IQueryableExtensions.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Extensions/IQueryableExtensions.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Extensions/IPageExtensions.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Extensions/IPageExtensions.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Chunk.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Chunk.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/IPage.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/IPage.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/IPageable.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/IPageable.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/ISlice.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/ISlice.cs'),{
            name: this.answers.name
          }
        );
        
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Page.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Page.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Pageable.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Pageable.cs'),{
            name: this.answers.name
          }
        );
        this.fs.copyTpl(
          this.templatePath('Template.Common/Pagination/Sort.cs.ejs'),
          this.destinationPath('src/'+this.answers.name+'.Common/Pagination/Sort.cs'),{
            name: this.answers.name
          }
        );

        this.fs.copyTpl(
          this.templatePath('Template.Common/Template.Common.csproj.ejs'),
          this.destinationPath('src/'+`${this.answers.name +'.Common/'+this.answers.name+'.Common.csproj'}`),{
            name: this.answers.name
          }
        );
  }


  writingCore(){
    this.fs.copyTpl(
      this.templatePath('Template.core/Clients/IHTTPClientHelper.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Clients/IHTTPClientHelper.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Data/ISqlConnectionFactory.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Data/ISqlConnectionFactory.cs'),{
        name: this.answers.name
      }
    ); 

    this.fs.copyTpl(
      this.templatePath('Template.core/Data/IUnitOfWork.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Data/IUnitOfWork.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Data/Repositories/ILogRepository.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Data/Repositories/ILogRepository.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Data/Repositories/IRepository.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Data/Repositories/IRepository.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Enums/Enums.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Enums/Enums.cs'),{
        name: this.answers.name
      }
    ); 
    
    this.fs.copyTpl(
      this.templatePath('Template.core/Models/BaseModel.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Models/BaseModel.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Models/Log.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Models/Log.cs'),{
        name: this.answers.name
      }
    ); 

    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/BadRequestAlertException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/BadRequestAlertException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/EmailAlreadyUsedException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/EmailAlreadyUsedException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/EmailNotFoundException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/EmailNotFoundException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/ErrorConstants.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/ErrorConstants.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/ExceptionTranslator.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/ExceptionTranslator.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/HTTPClientException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/HTTPClientException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/InternalServerErrorException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/InternalServerErrorException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/InvalidPasswordException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/InvalidPasswordException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/LoginAlreadyUsedException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/LoginAlreadyUsedException.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/ProblemDetailsConfiguration.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/ProblemDetailsConfiguration.cs'),{
        name: this.answers.name
      }
    ); 
    this.fs.copyTpl(
      this.templatePath('Template.core/Problems/ValidationFailedException.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Problems/ValidationFailedException.cs'),{
        name: this.answers.name
      }
    );
    this.fs.copyTpl(
      this.templatePath('Template.core/Services/ILogService.cs.ejs'),
      this.destinationPath('src/'+this.answers.name+'.core/Services/ILogService.cs'),{
        name: this.answers.name
      }
    );
  
    this.fs.copyTpl(
      this.templatePath('Template.Core/Template.Core.csproj.ejs'),
      this.destinationPath('src/'+`${this.answers.name +'.Core/'+this.answers.name+'.Core.csproj'}`),{
        name: this.answers.name
      }
    );
}



writingData(){
  this.fs.copyTpl(
    this.templatePath('Template.Data/Configurations/BaseModelConfiguration.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Configurations/BaseModelConfiguration.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/Configurations/LogConfiguration.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Configurations/LogConfiguration.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/Configurations/Applicator/ConfigurationApplicator.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Configurations/Applicator/ConfigurationApplicator.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/Configurations/Applicator/ConfigurationWrapper.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Configurations/Applicator/ConfigurationWrapper.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/Query/GetLogByIdQuery.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Query/GetLogByIdQuery.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/Query/GetLogByIdQueryHandler.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Query/GetLogByIdQueryHandler.cs'),{
      name: this.answers.name
    }
  ); 


  this.fs.copyTpl(
    this.templatePath('Template.Data/Repositories/LogRepository.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Repositories/LogRepository.cs'),{
      name: this.answers.name
    }
  ); 
  
  this.fs.copyTpl(
    this.templatePath('Template.Data/Repositories/Repository.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/Repositories/Repository.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/SqlConnectionFactory.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/SqlConnectionFactory.cs'),{
      name: this.answers.name
    }
  ); 

  this.fs.copyTpl(
    this.templatePath('Template.Data/UnitOfWork.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Data/UnitOfWork.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Data/TemplateDBContext.cs.ejs'),
    this.destinationPath('src/'+`${this.answers.name +'.Data/'+this.answers.name+'DBContext.cs'}`),{
      name: this.answers.name
    }
  );
  this.fs.copyTpl(
    this.templatePath('Template.Data/Template.Data.csproj.ejs'),
    this.destinationPath('src/'+`${this.answers.name +'.Data/'+this.answers.name+'.Data.csproj'}`),{
      name: this.answers.name
    }
  );
}











writingService(){
 
  this.fs.copyTpl(
    this.templatePath('Template.Service/Services/ImplLog/LogDBService.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Service/Services/ImplLog/LogDBService.cs'),{
      name: this.answers.name
    }
  ); 
  this.fs.copyTpl(
    this.templatePath('Template.Service/Services/ImplLog/LogFileService.cs.ejs'),
    this.destinationPath('src/'+this.answers.name+'.Service/Services/ImplLog/LogFileService.cs'),{
      name: this.answers.name
    }
  );
  this.fs.copyTpl(
    this.templatePath('Template.Service/Template.Service.csproj.ejs'),
    this.destinationPath('src/'+`${this.answers.name +'.Service/'+this.answers.name+'.Service.csproj'}`),{
      name: this.answers.name
    }
  );
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