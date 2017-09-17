import { NgModule }             from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NgApp2Component }      from './ng-app-2.component'

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: NgApp2Component }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class NgApp2RoutingModule { }
