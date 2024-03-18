import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { NgxSpinnerModule } from 'ngx-spinner';



@NgModule({
  declarations: [
    NavBarComponent,
    
  ],
  imports: [
    CommonModule,
    NgxSpinnerModule
  ],
  exports:[
    NavBarComponent,
    NgxSpinnerModule
  ]
})
export class CoreModule { }
