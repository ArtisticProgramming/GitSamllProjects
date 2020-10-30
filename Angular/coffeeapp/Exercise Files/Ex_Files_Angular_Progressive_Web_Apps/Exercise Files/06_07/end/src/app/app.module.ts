import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { GeolocationService } from "./geolocation.service";
import { AppComponent } from './app.component';
import { DataService } from "./data.service";

import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MdButtonModule, MdIconModule, MdInputModule, MdSelectModule, MdSliderModule,
         MdToolbarModule, MdCardModule, MdSlideToggleModule,
         MdSnackBarModule } from "@angular/material";
import 'hammerjs';
import { ListComponent } from './list/list.component';
import { CoffeeComponent } from './coffee/coffee.component';
import { Routes, RouterModule } from "@angular/router";
import { ServiceWorkerModule } from "@angular/service-worker";

import { FormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";

const routes : Routes = [
  { path: '', component: ListComponent },
  { path: 'coffee', component: CoffeeComponent },
  { path: 'coffee/:id', component: CoffeeComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    ListComponent,
    CoffeeComponent
  ],
  imports: [
    RouterModule.forRoot(routes),
    FormsModule, HttpModule, ServiceWorkerModule,
    BrowserModule, BrowserAnimationsModule,
    MdButtonModule, MdIconModule, MdInputModule, MdSelectModule, MdSliderModule,
    MdToolbarModule, MdCardModule, MdSlideToggleModule, MdSnackBarModule
  ],
  providers: [GeolocationService, DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
