/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./out/main.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./out/card-service.js":
/*!*****************************!*\
  !*** ./out/card-service.js ***!
  \*****************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\nvar CardService = /** @class */ (function () {\r\n    function CardService() {\r\n    }\r\n    CardService.prototype.drawCard = function () {\r\n        throw new Error(\"Method not implemented.\");\r\n    };\r\n    CardService.prototype.newDeck = function () {\r\n        throw new Error(\"Method not implemented.\");\r\n    };\r\n    return CardService;\r\n}());\r\n/* harmony default export */ __webpack_exports__[\"default\"] = (CardService);\r\n\n\n//# sourceURL=webpack:///./out/card-service.js?");

/***/ }),

/***/ "./out/main.js":
/*!*********************!*\
  !*** ./out/main.js ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony import */ var _page__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./page */ \"./out/page.js\");\n/* harmony import */ var _card_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./card-service */ \"./out/card-service.js\");\n//Singe page application\r\n//itll still just have onew view pretty much but\r\n\r\n\r\nvar cardService = new _card_service__WEBPACK_IMPORTED_MODULE_1__[\"default\"]();\r\nvar page = new _page__WEBPACK_IMPORTED_MODULE_0__[\"default\"](cardService);\r\npage.run();\r\n\n\n//# sourceURL=webpack:///./out/main.js?");

/***/ }),

/***/ "./out/page.js":
/*!*********************!*\
  !*** ./out/page.js ***!
  \*********************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\nvar Page = /** @class */ (function () {\r\n    function Page(cardService) {\r\n        var _this = this;\r\n        this.cardContainer = null;\r\n        this.newDeck = null;\r\n        this.drawCard = null;\r\n        this.count = null;\r\n        this.cardService = cardService;\r\n        document.addEventListener('DOMContentLoaded', function () {\r\n            _this.cardContainer = document.getElementById('card-container');\r\n            _this.newDeck = document.getElementById('new-deck');\r\n            _this.drawCard = document.getElementById('draw-card');\r\n            _this.count = 1;\r\n        });\r\n    }\r\n    Page.prototype.run = function () {\r\n        var _this = this;\r\n        document.addEventListener('DOMContentLoaded', function () {\r\n            var _a, _b;\r\n            // set up new deck action\r\n            (_a = _this.newDeck) === null || _a === void 0 ? void 0 : _a.addEventListener('click', function () {\r\n                _this.cardService.newDeck().then(function () {\r\n                    // TODO: empty the card container of any existing cards\r\n                    _this.makeAjaxRequestNewDeckFetch('https://deckofcardsapi.com/api/deck/new/');\r\n                }, function (error) {\r\n                    // TODO: display \r\n                    if (_this.cardContainer)\r\n                        _this.cardContainer.textContent = 'error: ' + error;\r\n                });\r\n            });\r\n            // set up draw card action\r\n            (_b = _this.drawCard) === null || _b === void 0 ? void 0 : _b.addEventListener('click', function () {\r\n                _this.cardService.drawCard().then(function () {\r\n                    // TODO: add the card to the card container\r\n                    _this.makeAjaxRequestDrawCardWithFetch('https://deckofcardsapi.com/api/deck/3p40paa87x90/draw/?count=' + _this.count);\r\n                    if (_this.count)\r\n                        _this.count++;\r\n                }, function (error) {\r\n                    // TODO: display error\r\n                    if (_this.cardContainer)\r\n                        _this.cardContainer.textContent = 'error: ' + error;\r\n                });\r\n            });\r\n        });\r\n    };\r\n    Page.prototype.makeAjaxRequestDrawCardWithFetch = function (url) {\r\n        var _this = this;\r\n        // the fetch function returns a Promise of the response.\r\n        fetch(url, { method: 'GET' })\r\n            .then(function (response) { return response.json(); })\r\n            .then(function (response) {\r\n            if (_this.drawCard)\r\n                _this.drawCard.textContent = 'Draw Card: ' + response.cards.value;\r\n        })\r\n            .catch(function (error) {\r\n            if (_this.drawCard)\r\n                _this.drawCard.textContent = 'error: ' + error;\r\n        }); // this callback will get some error object\r\n        // if you return a Promise in a .then callback...\r\n        // you can chain the next aciton to take in _another_ .then\r\n        // out at the same level\r\n        // the Response object that the Promise resolves with\r\n        // doesn't have the whole body yet, just the response headers\r\n    };\r\n    Page.prototype.makeAjaxRequestNewDeckFetch = function (url) {\r\n        var _this = this;\r\n        // the fetch function returns a Promise of the response.\r\n        fetch(url, { method: 'GET' })\r\n            .then(function (response) { return response.json(); })\r\n            .then(function (response) {\r\n            if (_this.cardContainer)\r\n                _this.cardContainer.textContent = response.cards.value;\r\n        })\r\n            .catch(function (error) {\r\n            if (_this.cardContainer)\r\n                _this.cardContainer.textContent = 'error: ' + error;\r\n        }); // this callback will get some error object\r\n        // if you return a Promise in a .then callback...\r\n        // you can chain the next aciton to take in _another_ .then\r\n        // out at the same level\r\n        // the Response object that the Promise resolves with\r\n        // doesn't have the whole body yet, just the response headers\r\n    };\r\n    return Page;\r\n}());\r\n/* harmony default export */ __webpack_exports__[\"default\"] = (Page);\r\n\n\n//# sourceURL=webpack:///./out/page.js?");

/***/ })

/******/ });