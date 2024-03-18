import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-itbs-resume',
  templateUrl: './itbs-resume.component.html',
  styleUrls: ['./itbs-resume.component.scss']
})
export class ItbsResumeComponent {



  @Input() itbs = 0
}
