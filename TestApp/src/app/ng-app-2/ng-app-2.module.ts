import { NgModule }      from '@angular/core';
import { CommonModule } from '@angular/common';

import { NgApp2RoutingModule } from './ng-app-2-routing.module';

import { NgApp2Component }  from './ng-app-2.component';

@NgModule({
    imports: [
        CommonModule,
        NgApp2RoutingModule
    ],
  declarations: [ NgApp2Component ]
})
export class NgApp2Module { }
