import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

export const routes: Routes = [
    { path: 'ngapp', loadChildren: 'app/ng-app/ng-app.module#NgAppModule' },
    { path: 'ngapp2', loadChildren: 'app/ng-app-2/ng-app-2.module#NgApp2Module' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
