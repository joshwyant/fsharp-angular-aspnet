import { NgModule }      from '@angular/core';
import { CommonModule } from '@angular/common';

import { NgAppRoutingModule } from './ng-app-routing.module';

import { NgAppComponent } from './ng-app.component';

@NgModule({
    imports: [
        CommonModule,
        NgAppRoutingModule
    ],
  declarations: [ NgAppComponent ]
})
export class NgAppModule { }
