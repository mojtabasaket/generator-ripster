#!/usr/bin/env node

const yeoman = require('yeoman-environment');
const env = yeoman.createEnv();

// The #lookup() method will search the user computer for installed generators
// The search if done from the current working directory
env.lookup(() => {
  env.run('ripster', {'skip-install': true}, err => {
    console.log('done');
  });
});
 