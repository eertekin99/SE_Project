package com.example.demo.Entity;

import javax.persistence.Entity;
import javax.persistence.*;
import java.util.*;

@Entity
@Table(name="cargo")
public class Cargo {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "ID")
    long CID;
    @Column(name = "Sender_ID")
    long SenderID;
    @Column(name = "Receiver_ID")
    long ReceiverID;
    @Column(name = "Deliverer_ID")
    long DelivererID;
    @Column(name = "Br_Employee_ID")
    long BREmployeeID;
    @Column(name = "Status")
    String Status;
    @Column(name = "Type")
    String Type;
    @Column(name = "Description")
    String Description;
    @Column(name = "Senders_Delivery_Date")
    Date SendersDeliveryDate;
    @Column(name = "Bill_ID")
    long BillID;
    @Column(name= "Receiver_Address")
    String ReceiverAddress;
    @Column(name="Weight")
    int Weight;
//    @ManyToMany(mappedBy = "cargos", fetch = FetchType.LAZY)
//    private Set<Branch> Branches = new HashSet<>();
    @OneToMany(mappedBy = "shipmentCargo", cascade = CascadeType.ALL)
    private List<Shipment> CargoBranch = new ArrayList<>();
    @ManyToOne
    @JoinColumn(name = "Sender_ID",insertable = false,updatable = false)
    Customer cargoSender;
    @ManyToOne
    @JoinColumn(name = "Receiver_ID",insertable = false,updatable = false)
    Customer cargoReceiver;
    @OneToOne
    @JoinColumn(name = "Bill_ID",insertable = false,updatable = false)
    Bill cargoBill;
//    @ManyToMany(fetch = FetchType.LAZY, cascade = CascadeType.PERSIST)
//    @JoinTable(name = "at",
//            joinColumns = {
//                    @JoinColumn(name = "Cargo_ID", referencedColumnName = "ID",
//                            nullable = false, updatable = false)},
//            inverseJoinColumns = {
//                    @JoinColumn(name = "Branch_ID", referencedColumnName = "ID",
//                            nullable = false, updatable = false)})
//    private Set<Branch> Branches = new HashSet<>();


    public long getCID() {
        return CID;
    }

    public void setCID(long CID) {
        this.CID = CID;
    }

    public long getSenderID() {
        return SenderID;
    }

    public void setSenderID(long senderID) {
        SenderID = senderID;
    }

    public long getReceiverID() {
        return ReceiverID;
    }

    public void setReceiverID(long receiverID) {
        ReceiverID = receiverID;
    }

    public long getDelivererID() {
        return DelivererID;
    }

    public void setDelivererID(long delivererID) {
        DelivererID = delivererID;
    }

    public long getBREmployeeID() {
        return BREmployeeID;
    }

    public void setBREmployeeID(long BREmployeeID) {
        this.BREmployeeID = BREmployeeID;
    }

    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }

    public String getType() {
        return Type;
    }

    public void setType(String type) {
        Type = type;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public Date getSendersDeliveryDate() {
        return SendersDeliveryDate;
    }

    public void setSendersDeliveryDate(Date sendersDeliveryDate) {
        SendersDeliveryDate = sendersDeliveryDate;
    }

    public long getBillID() {
        return BillID;
    }

    public void setBillID(long billID) {
        BillID = billID;
    }

    public String getReceiverAddress() {
        return ReceiverAddress;
    }

    public void setReceiverAddress(String receiverAddress) {
        ReceiverAddress = receiverAddress;
    }

    public int getWeight() {
        return Weight;
    }

    public void setWeight(int weight) {
        Weight = weight;
    }

    public List<Shipment> getCargoBranch() {
        return CargoBranch;
    }

    public void setCargoBranch(List<Shipment> cargoBranch) {
        CargoBranch = cargoBranch;
    }

    public Customer getCargoSender() {
        return cargoSender;
    }

    public void setCargoSender(Customer cargoSender) {
        this.cargoSender = cargoSender;
    }

    public Customer getCargoReceiver() {
        return cargoReceiver;
    }

    public void setCargoReceiver(Customer cargoReceiver) {
        this.cargoReceiver = cargoReceiver;
    }

    public Bill getCargoBill() {
        return cargoBill;
    }

    public void setCargoBill(Bill cargoBill) {
        this.cargoBill = cargoBill;
    }
}
