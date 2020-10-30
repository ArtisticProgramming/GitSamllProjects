webpackJsonp([1],{

/***/ "../../../../../src async recursive":
/***/ (function(module, exports) {

function webpackEmptyContext(req) {
	throw new Error("Cannot find module '" + req + "'.");
}
webpackEmptyContext.keys = function() { return []; };
webpackEmptyContext.resolve = webpackEmptyContext;
module.exports = webpackEmptyContext;
webpackEmptyContext.id = "../../../../../src async recursive";

/***/ }),

/***/ "../../../../../src/app/app.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<md-toolbar color=\"primary\">\n  <h1>My Coffee App</h1>\n</md-toolbar>\n\n<router-outlet></router-outlet>\n"

/***/ }),

/***/ "../../../../../src/app/app.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AppComponent = (function () {
    function AppComponent() {
        this.title = 'app';
    }
    return AppComponent;
}());
AppComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_1" /* Component */])({
        selector: 'app-root',
        template: __webpack_require__("../../../../../src/app/app.component.html"),
        styles: [__webpack_require__("../../../../../src/app/app.component.css")]
    })
], AppComponent);

//# sourceMappingURL=app.component.js.map

/***/ }),

/***/ "../../../../../src/app/app.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__ = __webpack_require__("../../../platform-browser/@angular/platform-browser.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__geolocation_service__ = __webpack_require__("../../../../../src/app/geolocation.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__app_component__ = __webpack_require__("../../../../../src/app/app.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__data_service__ = __webpack_require__("../../../../../src/app/data.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__angular_platform_browser_animations__ = __webpack_require__("../../../platform-browser/@angular/platform-browser/animations.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__angular_material__ = __webpack_require__("../../../material/@angular/material.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7_hammerjs__ = __webpack_require__("../../../../hammerjs/hammer.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7_hammerjs___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_7_hammerjs__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__list_list_component__ = __webpack_require__("../../../../../src/app/list/list.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__coffee_coffee_component__ = __webpack_require__("../../../../../src/app/coffee/coffee.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_11__angular_forms__ = __webpack_require__("../../../forms/@angular/forms.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_12__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};













var routes = [
    { path: '', component: __WEBPACK_IMPORTED_MODULE_8__list_list_component__["a" /* ListComponent */] },
    { path: 'coffee', component: __WEBPACK_IMPORTED_MODULE_9__coffee_coffee_component__["a" /* CoffeeComponent */] },
    { path: 'coffee/:id', component: __WEBPACK_IMPORTED_MODULE_9__coffee_coffee_component__["a" /* CoffeeComponent */] }
];
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_core__["b" /* NgModule */])({
        declarations: [
            __WEBPACK_IMPORTED_MODULE_3__app_component__["a" /* AppComponent */],
            __WEBPACK_IMPORTED_MODULE_8__list_list_component__["a" /* ListComponent */],
            __WEBPACK_IMPORTED_MODULE_9__coffee_coffee_component__["a" /* CoffeeComponent */]
        ],
        imports: [
            __WEBPACK_IMPORTED_MODULE_10__angular_router__["a" /* RouterModule */].forRoot(routes),
            __WEBPACK_IMPORTED_MODULE_11__angular_forms__["a" /* FormsModule */], __WEBPACK_IMPORTED_MODULE_12__angular_http__["a" /* HttpModule */],
            __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__["a" /* BrowserModule */], __WEBPACK_IMPORTED_MODULE_5__angular_platform_browser_animations__["a" /* BrowserAnimationsModule */],
            __WEBPACK_IMPORTED_MODULE_6__angular_material__["a" /* MdButtonModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["b" /* MdIconModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["c" /* MdInputModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["d" /* MdSelectModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["e" /* MdSliderModule */],
            __WEBPACK_IMPORTED_MODULE_6__angular_material__["f" /* MdToolbarModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["g" /* MdCardModule */], __WEBPACK_IMPORTED_MODULE_6__angular_material__["h" /* MdSlideToggleModule */]
        ],
        providers: [__WEBPACK_IMPORTED_MODULE_2__geolocation_service__["a" /* GeolocationService */], __WEBPACK_IMPORTED_MODULE_4__data_service__["a" /* DataService */]],
        bootstrap: [__WEBPACK_IMPORTED_MODULE_3__app_component__["a" /* AppComponent */]]
    })
], AppModule);

//# sourceMappingURL=app.module.js.map

/***/ }),

/***/ "../../../../../src/app/coffee/coffee.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "md-card {\n    margin: 20px;\n}\n\nmd-input-container, md-select {\n    width: 100%\n}\n\nmd-card-title {\n    font-size: larger;\n}\n\nmd-slider {\n    width: 90%;\n}", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/coffee/coffee.component.html":
/***/ (function(module, exports) {

module.exports = "<form>\n\n  <md-card>\n    <md-card-title>\n      Basic Coffee Information\n    </md-card-title>\n    <md-input-container>\n      <input mdInput placeholder=\"Coffee Name\" name=\"name\" [(ngModel)]=\"coffee.name\">\n    </md-input-container>\n    <md-select placeholder=\"Coffee Type\" name=\"type\" [(ngModel)]=\"coffee.type\">\n      <md-option *ngFor=\"let type of types\" [value]=\"type\">\n        {{ type }}\n      </md-option>\n    </md-select>\n  </md-card>\n\n  <md-card>\n    <md-card-title>\n      Place Information\n    </md-card-title>\n    <md-input-container>\n      <input mdInput placeholder=\"Place Name\" name=\"place\" [(ngModel)]=\"coffee.place\">\n    </md-input-container>\n\n    <md-input-container>\n      <input mdInput placeholder=\"Address\" name=\"address\" [(ngModel)]=\"coffee.location.address\">\n    </md-input-container>\n\n    <md-input-container>\n      <input mdInput placeholder=\"City\" name=\"city\" [(ngModel)]=\"coffee.location.city\">\n    </md-input-container>\n  </md-card>\n\n  <md-card>\n     <md-card-title>\n      Ratings\n    </md-card-title>\n    \n    <md-card-subtitle>Overall Rating</md-card-subtitle>\n    <md-slider max=\"10\" thumbLabel name=\"rating\"\n      [(ngModel)]=\"coffee.rating\" tickInterval=\"1\"></md-slider>\n\n    <md-card-subtitle>\n      <md-slide-toggle #tastingSelector [checked]=\"tastingEnabled\"\n       (change)=\"tastingRatingChanged(tastingSelector.checked)\">Tasting Ratings</md-slide-toggle>\n    </md-card-subtitle>\n\n    <section id=\"tasting\" *ngIf=\"tastingSelector.checked\">\n      <label>Aroma</label>\n      <md-slider max=\"10\" thumbLabel name=\"aromaRating\"\n      [(ngModel)]=\"coffee.tastingRating.aroma\" tickInterval=\"1\"></md-slider>\n\n      <label>Flavor</label>\n      <md-slider max=\"10\" thumbLabel name=\"flavorRating\"\n      [(ngModel)]=\"coffee.tastingRating.flavor\" tickInterval=\"1\"></md-slider>\n\n      <label>Intensity</label>\n      <md-slider max=\"10\" thumbLabel name=\"intensityRating\"\n      [(ngModel)]=\"coffee.tastingRating.intensity\" tickInterval=\"1\"></md-slider>\n\n      <label>Sweetness</label>\n      <md-slider max=\"10\" thumbLabel name=\"sweetnessRating\"\n      [(ngModel)]=\"coffee.tastingRating.sweetness\" tickInterval=\"1\"></md-slider>\n\n      <label>Aftertaste</label>\n      <md-slider max=\"10\" thumbLabel name=\"aftertasteRating\"\n      [(ngModel)]=\"coffee.tastingRating.aftertaste\" tickInterval=\"1\"></md-slider>\n\n    </section>\n\n  </md-card>\n\n  <md-card>\n    <md-input-container>\n      <textarea mdInput placeholder=\"Notes\" name=\"notes\" [(ngModel)]=\"coffee.notes\">\n    </textarea>\n    </md-input-container>\n\n  </md-card>\n\n  <md-card>\n    <button md-raised-button (click)=\"cancel()\">Cancel</button>\n    <button md-raised-button color=\"accent\" (click)=\"save()\">Save</button>\n  </md-card>\n\n</form>"

/***/ }),

/***/ "../../../../../src/app/coffee/coffee.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__logic_Coffee__ = __webpack_require__("../../../../../src/app/logic/Coffee.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__geolocation_service__ = __webpack_require__("../../../../../src/app/geolocation.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__logic_TastingRating__ = __webpack_require__("../../../../../src/app/logic/TastingRating.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__data_service__ = __webpack_require__("../../../../../src/app/data.service.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return CoffeeComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






var CoffeeComponent = (function () {
    function CoffeeComponent(route, geolocation, router, data) {
        this.route = route;
        this.geolocation = geolocation;
        this.router = router;
        this.data = data;
        this.tastingEnabled = false;
        this.types = ["Espresso", "Ristretto", "Americano", "Cappuccino", "Frappe"];
    }
    CoffeeComponent.prototype.tastingRatingChanged = function (checked) {
        if (checked) {
            this.coffee.tastingRating = new __WEBPACK_IMPORTED_MODULE_4__logic_TastingRating__["a" /* TastingRating */]();
        }
        else {
            this.coffee.tastingRating = null;
        }
    };
    CoffeeComponent.prototype.cancel = function () {
        this.router.navigate(["/"]);
    };
    CoffeeComponent.prototype.save = function () {
        var _this = this;
        this.data.save(this.coffee, function (result) {
            if (result) {
                _this.router.navigate(["/"]);
            }
        });
    };
    CoffeeComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.coffee = new __WEBPACK_IMPORTED_MODULE_2__logic_Coffee__["a" /* Coffee */]();
        this.routingSubscription =
            this.route.params.subscribe(function (params) {
                console.log(params["id"]);
                if (params["id"]) {
                    _this.data.get(params["id"], function (response) {
                        _this.coffee = response;
                        if (_this.coffee.tastingRating) {
                            _this.tastingEnabled = true;
                        }
                    });
                }
            });
        this.geolocation.requestLocation(function (location) {
            if (location) {
                _this.coffee.location.latitude = location.latitude;
                _this.coffee.location.longitude = location.longitude;
            }
        });
    };
    CoffeeComponent.prototype.ngOnDestroy = function () {
        this.routingSubscription.unsubscribe();
    };
    return CoffeeComponent;
}());
CoffeeComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_1" /* Component */])({
        selector: 'app-coffee',
        template: __webpack_require__("../../../../../src/app/coffee/coffee.component.html"),
        styles: [__webpack_require__("../../../../../src/app/coffee/coffee.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* ActivatedRoute */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* ActivatedRoute */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_3__geolocation_service__["a" /* GeolocationService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__geolocation_service__["a" /* GeolocationService */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["c" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["c" /* Router */]) === "function" && _c || Object, typeof (_d = typeof __WEBPACK_IMPORTED_MODULE_5__data_service__["a" /* DataService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_5__data_service__["a" /* DataService */]) === "function" && _d || Object])
], CoffeeComponent);

var _a, _b, _c, _d;
//# sourceMappingURL=coffee.component.js.map

/***/ }),

/***/ "../../../../../src/app/data.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return DataService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var DataService = (function () {
    function DataService(http) {
        this.http = http;
        this.endpoint = "http://localhost:3000";
    }
    DataService.prototype.get = function (coffeeId, callback) {
        this.http.get(this.endpoint + "/coffees/" + coffeeId)
            .subscribe(function (response) {
            callback(response.json());
        });
    };
    DataService.prototype.getList = function (callback) {
        // const list = [
        //   new Coffee("Double Espresso", "Sunny Cafe", new PlaceLocation("123 Market St", "San Francisco")),
        //   new Coffee("Caramel Americano", "Starcoffee", new PlaceLocation("Gran Via 34", "Madrid"))
        // ]; 
        // callback(list);
        this.http.get(this.endpoint + "/coffees")
            .subscribe(function (response) {
            console.log(response.json());
            callback(response.json());
        });
    };
    DataService.prototype.save = function (coffee, callback) {
        if (coffee._id) {
            // It's an update
            this.http.put(this.endpoint + "/coffees/" + coffee._id, coffee)
                .subscribe(function (response) {
                callback(true);
            });
        }
        else {
            // It's an insert
            this.http.post(this.endpoint + "/coffees", coffee)
                .subscribe(function (response) {
                callback(true);
            });
        }
    };
    return DataService;
}());
DataService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_http__["b" /* Http */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_http__["b" /* Http */]) === "function" && _a || Object])
], DataService);

var _a;
//# sourceMappingURL=data.service.js.map

/***/ }),

/***/ "../../../../../src/app/geolocation.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return GeolocationService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var GeolocationService = (function () {
    function GeolocationService() {
    }
    GeolocationService.prototype.requestLocation = function (callback) {
        // W3C Geolocation API
        navigator.geolocation.getCurrentPosition(function (position) {
            callback(position.coords);
        }, function (error) {
            callback(null);
        });
    };
    GeolocationService.prototype.getMapLink = function (location) {
        var query = "";
        if (location.latitude) {
            query = location.latitude + "," + location.longitude;
        }
        else {
            query = location.address + ", " + location.city;
        }
        if (/iPad|iPhone|iPod/.test(navigator.userAgent)) {
            return "https://maps.apple.com/?q=" + query;
        }
        else {
            return "https://maps.google.com/?q=" + query;
        }
        // Universal Link
        // <a href="https://maps.google.com/?q=Eiffel+Tower">
        // <a href="https://maps.apple.com/?q=34.44,56.44">
    };
    return GeolocationService;
}());
GeolocationService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [])
], GeolocationService);

//# sourceMappingURL=geolocation.service.js.map

/***/ }),

/***/ "../../../../../src/app/list/list.component.css":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, "#btnCreate {\n    position: fixed;\n    right: 20px;\n    bottom: 20px;\n}", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/list/list.component.html":
/***/ (function(module, exports) {

module.exports = "<md-card *ngFor=\"let coffee of list\">\n   <md-card-title>{{ coffee.name }}</md-card-title>\n   <md-card-subtitle>Place: {{ coffee.place }}</md-card-subtitle>\n   <md-card-actions>\n     <button md-button><md-icon>map</md-icon></button>\n     <button md-button><md-icon>share</md-icon></button>\n     <button (click)=\"goDetails(coffee)\" md-button><md-icon>list</md-icon></button>\n   </md-card-actions>\n</md-card>\n\n<a id=\"btnCreate\" md-fab routerLink=\"/coffee\"><md-icon>create</md-icon></a>"

/***/ }),

/***/ "../../../../../src/app/list/list.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__data_service__ = __webpack_require__("../../../../../src/app/data.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ListComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var ListComponent = (function () {
    function ListComponent(data, router) {
        this.data = data;
        this.router = router;
    }
    ListComponent.prototype.goDetails = function (coffee) {
        this.router.navigate(["/coffee", coffee._id]);
    };
    ListComponent.prototype.ngOnInit = function () {
        var _this = this;
        console.log("init");
        this.data.getList(function (list) {
            _this.list = list;
        });
    };
    return ListComponent;
}());
ListComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_1" /* Component */])({
        selector: 'app-list',
        template: __webpack_require__("../../../../../src/app/list/list.component.html"),
        styles: [__webpack_require__("../../../../../src/app/list/list.component.css")]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__data_service__["a" /* DataService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__data_service__["a" /* DataService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_2__angular_router__["c" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__angular_router__["c" /* Router */]) === "function" && _b || Object])
], ListComponent);

var _a, _b;
//# sourceMappingURL=list.component.js.map

/***/ }),

/***/ "../../../../../src/app/logic/Coffee.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__TastingRating__ = __webpack_require__("../../../../../src/app/logic/TastingRating.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__PlaceLocation__ = __webpack_require__("../../../../../src/app/logic/PlaceLocation.ts");
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return Coffee; });


var Coffee = (function () {
    function Coffee(name, place, location) {
        if (name === void 0) { name = ""; }
        if (place === void 0) { place = ""; }
        if (location === void 0) { location = null; }
        this.name = name;
        this.place = place;
        this.location = location;
        this.location = new __WEBPACK_IMPORTED_MODULE_1__PlaceLocation__["a" /* PlaceLocation */]();
        this.tastingRating = new __WEBPACK_IMPORTED_MODULE_0__TastingRating__["a" /* TastingRating */]();
    }
    return Coffee;
}());

//# sourceMappingURL=Coffee.js.map

/***/ }),

/***/ "../../../../../src/app/logic/PlaceLocation.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return PlaceLocation; });
var PlaceLocation = (function () {
    function PlaceLocation(address, city, latitude, longitude) {
        if (address === void 0) { address = ""; }
        if (city === void 0) { city = ""; }
        if (latitude === void 0) { latitude = null; }
        if (longitude === void 0) { longitude = null; }
        this.address = address;
        this.city = city;
        this.latitude = latitude;
        this.longitude = longitude;
    }
    return PlaceLocation;
}());

//# sourceMappingURL=PlaceLocation.js.map

/***/ }),

/***/ "../../../../../src/app/logic/TastingRating.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TastingRating; });
var TastingRating = (function () {
    function TastingRating() {
    }
    return TastingRating;
}());

//# sourceMappingURL=TastingRating.js.map

/***/ }),

/***/ "../../../../../src/environments/environment.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
// The file contents for the current environment will overwrite these during build.
var environment = {
    production: false
};
//# sourceMappingURL=environment.js.map

/***/ }),

/***/ "../../../../../src/main.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__("../../../platform-browser-dynamic/@angular/platform-browser-dynamic.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__("../../../../../src/app/app.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__("../../../../../src/environments/environment.ts");




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["a" /* enableProdMode */])();
}
__webpack_require__.i(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */]);
//# sourceMappingURL=main.js.map

/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("../../../../../src/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map