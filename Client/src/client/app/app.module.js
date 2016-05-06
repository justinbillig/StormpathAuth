(function() {
  'use strict';

  var app = angular.module('app', [
    'app.core',
    'app.widgets',
    'app.admin',
    'app.dashboard',
    'app.values',
    'app.layout',
    'app.login'
  ]);

   app.config(function(STORMPATH_CONFIG){
         //STORMPATH_CONFIG.ENDPOINT_PREFIX = 'http://localhost:53175';
     });

})();
