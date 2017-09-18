import { NgModule }      from '@angular/core';
import { CommonModule } from '@angular/common';

import { CrudRoutingModule } from './crud-routing.module';

import { CrudComponent } from './crud.component';

@NgModule({
    imports: [
        CommonModule,
        CrudRoutingModule
    ],
  declarations: [ CrudComponent ]
})
export class CrudModule { }
