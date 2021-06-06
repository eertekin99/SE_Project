package com.example.demo.Entity;

import javax.persistence.*;

@Entity

@Table(name = "bill")
public class Bill {
    @Id
    @Column(name ="ID")
    long ID;
    @Column(name ="Cost")
    double cost;
    @Column(name = "Payment_Type")
    String paymentType;

    @ManyToOne
    @JoinColumn(name="Sender_ID")
    Customer customerBill;
    @OneToOne(mappedBy = "cargoBill")
    Cargo cargo;

    public Cargo getCargo() {
        return cargo;
    }

    public void setCargo(Cargo cargo) {
        this.cargo = cargo;
    }

    public void setID(long ID) {
        this.ID = ID;
    }

    public void setCost(double cost) {
        this.cost = cost;
    }

    public void setPaymentType(String paymentType) {
        this.paymentType = paymentType;
    }

    public void setCustomerBill(Customer customerBill) {
        this.customerBill = customerBill;
    }

    public long getID() {
        return ID;
    }

    public double getCost() {
        return cost;
    }

    public String getPaymentType() {
        return paymentType;
    }

    public Customer getCustomerBill() {
        return customerBill;
    }

}
