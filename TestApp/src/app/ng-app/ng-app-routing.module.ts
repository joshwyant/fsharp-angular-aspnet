import { NgModule }             from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NgAppComponent }       from './ng-app.component'

export const routes: Routes = [
    { path: '', component: NgAppComponent, pathMatch: 'full' }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class NgAppRoutingModule { }
