import { Component } from '@angular/core';

@Component({
    selector: 'app-footer',
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.scss']
})
/** footer component*/
export class FooterComponent {
  /** footer ctor */
  test: Date = new Date();

    constructor() {

    }
}
