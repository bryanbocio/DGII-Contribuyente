import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ItbsResumeComponent } from './itbs-resume/itbs-resume.component';



@NgModule({
  declarations: [
    ItbsResumeComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    ItbsResumeComponent
  ]
})
export class SharedModule { }
