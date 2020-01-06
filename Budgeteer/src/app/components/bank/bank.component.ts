import { Component, OnInit, Input } from '@angular/core';
import { Bank } from 'src/app/models/bank';

@Component({
  selector: 'app-bank',
  templateUrl: './bank.component.html',
  styleUrls: ['./bank.component.scss']
})
export class BankComponent implements OnInit {

  @Input() bank: Bank;
  constructor() { }

  ngOnInit() {
  }

}
