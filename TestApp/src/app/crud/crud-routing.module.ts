import { NgModule }             from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CrudComponent } from './crud.component';

export const routes: Routes = [
    { path: '', component: CrudComponent, pathMatch: 'full' }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class CrudRoutingModule { }
