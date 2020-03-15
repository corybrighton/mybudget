import { Component, OnInit, Input } from '@angular/core';
import { Bank } from 'src/app/models/bank';
import { AccountsService } from 'src/app/services/accounts.service';

@Component({
  selector: 'app-bank',
  templateUrl: './bank.component.html',
  styleUrls: ['./bank.component.scss']
})
export class BankComponent implements OnInit {
  editing = false;

  @Input() bank: Bank;
  constructor(private accountServe: AccountsService) { }

  ngOnInit() {
    console.log(this.bank)
  }

  editBank() {
    this.editing = true;
  }

  saveBank() {
    this.editing = false;
    this.accountServe.editBank(this.bank).subscribe(res => console.log(res));
    // Todo save bank
  }

  deleteBank() {
    // Todo delete Bank
    console.log('Delete Bank');
  }
}
