import { Component } from '@angular/core';

@Component({
	selector: 'hero',
	template: `<h1>Hello {{title}}</h1>`
})
export class HeroComponent {
	title = "hero";
	hero = "done";
}
