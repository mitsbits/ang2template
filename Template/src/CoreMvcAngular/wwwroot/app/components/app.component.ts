﻿import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    templateUrl: 'app/components/app.component.html'
})

export class AppComponent {
    public appName: string;
    constructor() {
        this.appName = 'Ang 2 App';
    }
}