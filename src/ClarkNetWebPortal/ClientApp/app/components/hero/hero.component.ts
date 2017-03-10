import { Component } from '@angular/core';

@Component({
	selector: 'hero',
	template: require('./hero.component.html')
})
export class HeroComponent {
	title = 'tour of heros';
	hero = 'windstorm';
}