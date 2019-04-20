import { Directive, ElementRef, Input } from '@angular/core';
var jquery: any = require('jquery');

@Directive({ selector: 'p' })
export class DropDownDirective {
	constructor(el: ElementRef) {
		//jquery(el).dropdown();
		//el.nativeElement.dropdown();
		el.nativeElement.style.backgroundColor = 'yellow'; 
		el.nativeElement.style.color = 'yellow';
	}
}

