(function() {
  'use strict';

    /**
    * @desc directive used to provide login and logout links
    * @example <dk-login-logout/>
    */
    angular
        .module('app.login')
        .directive('dkLoginLogout', loginLogout);

    function loginLogout() {
        var directive = {
            templateUrl: 'app/login/login.directive.html',
            restrict: 'E',
        };
        
        return directive;
    }
})();
