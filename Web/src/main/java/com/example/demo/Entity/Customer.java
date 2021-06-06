package com.example.demo.Entity;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
@Table(name ="customer")
public class Customer {
    @Id
    @Column(name ="ID")
    private long ID;
    @Column(name="Address")
    String Address;
    @Column(name="Email")
    String email;
    @Column(name="Name")
    String name;
    @Column(name="Mobile_Phone")
    String CMobile;
    @Column(name="Type")
    String Type;
    @OneToMany(mappedBy = "customerBill")
    List<Bill> Bills = new ArrayList<>();
    @OneToMany(mappedBy = "cargoSender")
    List<Cargo> cargosSent = new ArrayList<>();
    @OneToMany(mappedBy = "cargoReceiver")
    List<Cargo> cargosReceived = new ArrayList<>();

    public long getID() {
        return ID;
    }

    public void setID(long ID) {
        this.ID = ID;
    }

    public String getAddress() {
        return Address;
    }

    public void setAddress(String address) {
        Address = address;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCMobile() {
        return CMobile;
    }

    public void setCMobile(String CMobile) {
        this.CMobile = CMobile;
    }

    public String getType() {
        return Type;
    }

    public void setType(String type) {
        Type = type;
    }

    public List<Bill> getBills() {
        return Bills;
    }

    public void setBills(List<Bill> bills) {
        Bills = bills;
    }

    public List<Cargo> getCargosSent() {
        return cargosSent;
    }

    public void setCargosSent(List<Cargo> cargosSent) {
        this.cargosSent = cargosSent;
    }

    public List<Cargo> getCargosReceived() {
        return cargosReceived;
    }

    public void setCargosReceived(List<Cargo> cargosReceived) {
        this.cargosReceived = cargosReceived;
    }
}
