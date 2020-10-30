import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { GeolocationService } from "./geolocation.service";
import { AppComponent } from './app.component';
import { DataService } from "./data.service";

import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MdButtonModule, MdIconModule, MdInputModule, MdSelectModule, MdSliderModule,
         MdToolbarModule, MdCardModule, MdSlideToggleModule } from "@angular/material";
import 'hammerjs';
import { ListComponent } from './list/list.component';
import { CoffeeComponent } from './coffee/coffee.component';

@NgModule({
  declarations: [
    AppComponent,
    ListComponent,
    CoffeeComponent
  ],
  imports: [
    BrowserModule, BrowserAnimationsModule,
    MdButtonModule, MdIconModule, MdInputModule, MdSelectModule, MdSliderModule,
    MdToolbarModule, MdCardModule, MdSlideToggleModule
  ],
  providers: [GeolocationService, DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
