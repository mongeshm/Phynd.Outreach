﻿import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'app';
    //onButtonClick() {
    //    this.title = 'Hello from Kendo UI!';
    //}
    public events: string[] = [];
    public source: Array<string> = ["Albania", "Andorra", "Armenia", "Austria", "Azerbaijan"];
    public data: Array<string>;

    constructor() {
        this.data = this.source.slice();
    }
}
