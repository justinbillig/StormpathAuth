(function() {
  'use strict';

  angular
    .module('app.login')
    .controller('LoginController', LoginController);

  LoginController.$inject = [];
  /* @ngInject */
  function LoginController() {
    var vm = this;
    vm.title = 'Login';
  }
})();
