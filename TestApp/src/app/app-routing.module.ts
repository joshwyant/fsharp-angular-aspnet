import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

export const routes: Routes = [
    { path: 'crud', loadChildren: 'app/crud/crud.module#CrudModule' },
    { path: 'ngapp2', loadChildren: 'app/ng-app-2/ng-app-2.module#NgApp2Module' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
