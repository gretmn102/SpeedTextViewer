module Core

open FsharpMyExtension.ListZipper
open System.Text.RegularExpressions

let txt = @"    <p>— Слава богу, нет, — сказала миссис Бивер, — только две горничные сдуру выбросились через стеклянную крышу на мощеный дворик. Им ничего не угрожало. Боюсь, что пожар так и не добрался до спален. Но без ремонта им не обойтись: там все покрыто копотью и насквозь промокло: у них, к счастью, оказался старомодный огнетушитель, который портит решительно все. Так что жаловаться не приходится. Главные комнаты выгорели дотла, но все было застраховано Надо добраться до них пораньше, пока их не перехватила эта стервоза миссис Шаттер.</p>
    <p>Миссис Бивер, грея спину у камина, поглощала свою ежеутреннюю порцию простокваши. Она держала картонный стаканчик под самым подбородком и жадно хлебала простоквашу ложкой.</p>
    <p>— Господи, какая гадость. Я бы хотела, чтоб ты приохотился к ней, Джон. У тебя последнее время такой усталый вид. Не знаю, как бы я продержалась без простокваши.</p>
    <p>— Но, мамчик, я ведь не так занят, как ты.</p>
    <p>— Это правда, сын мой.</p>
    <p>Джон Бивер жил с матерью в доме на Сассекс-гарденз, куда они переехали после смерти отца. Дом этот не имел ничего общего с теми сурово элегантными интерьерами, которые миссис Бивер создавала для своих клиентов. Он был набит непродажной мебелью из двух больших домов, не претендующей на принадлежность ни к одному определенному стилю и менее всего — к нынешнему. Предметы получше, а также те, которые были дороги миссис Бивер по сентиментальным соображениям, стояли в Г-образной гостиной наверху.</p>
    <p>Бивер являлся обладателем темноватой маленькой гостиной (на первом этаже, за столовой) и отдельного телефона. Пожилая горничная приглядывала за его гардеробом Она же вытирала пыль, начищала, поддерживала в порядке и симметрии стоявшую на письменном столе и на комоде коллекцию мрачных и громоздких предметов, украшавших прежде туалетную комнату его отца; не знающие сносу подарки к свадьбе и совершеннолетию, одетые в слоновую кость и бронзу, обтянутые свиной кожей, граненые и оправленные в золото доспехи дорогостоящей мужественности эдвардианских времен — фляги для бегов и фляги для охоты, ящики для сигар, банки для табака, высокие сапоги, вычурные пенковые трубки, крючки для пуговиц и щетки для шляп.</p>
    <p>В доме было четверо слуг, все женщины, и все, за исключением одной, пожилые.</p>
    <p>Когда Бивера спрашивали, почему он живет здесь, а не поселится отдельно, он иногда отвечал, что матери так лучше (несмотря на всю ее занятость, ей было бы тоскливо одной), а иногда, что он экономит на этом по меньшей мере фунтов пять в неделю.</p>
    <p>Учитывая, что его недельный доход равнялся шести фунтам, экономия была довольно существенная.</p>
    <p>Ему шел двадцать шестой год. По окончании Оксфорда он, пока не начался кризис, работал в рекламном агентстве. С тех пор никому не удалось подыскать ему место. Итак, он вставал поздно и почти весь день просиживал у телефона в ожидании звонка.</p>
    <p>Если дела позволяли, миссис Бивер попозже отлучалась на час из лавки. Она пунктуальнейшим образом являлась туда к девяти и к половине двенадцатого уже нуждалась в отдыхе. Так что если не ожидался важный покупатель, она садилась в свой двухместный автомобиль и ехала на Сассекс-гарденз. Бивер обычно уже успевал одеться, и ей со временем стал просто необходим их утренний обмен сплетнями.</p>
    <p>— Как провел вечер?</p>
    <p>— В восемь позвонила Одри и пригласила на обед. Десять человек в «Эмбасси», тоска смертная. Потом поехали всей компанией к даме по фамилии де Тромме.</p>
    <p>— А, знаю ее. Американка. Она еще не заплатила за набивные чехлы на стулья, которые мы ей сделали в прошлом апреле. У меня тоже был неудачный вечер: ни одной хорошей карты, — и в результате четыре фунта десять проигрышу.</p>
    <p>— Бедный мамчик.</p>
    <p>— Я обедаю у Виолы Казм. А ты? Я не заказала дома обеда, ты уж извини.</p>
    <p>— Пока нигде. Правда, я всегда могу пойти к Брэтту.</p>
    <p>— Но это так дорогоо. Я думаю если мы попросим Чэмберс, она тебе что-нибудь принесет. Я была уверена, что ты приглашен.</p>
    <p>— Что ж, меня еще могут пригласить: ведь нет и двенадцати.</p>
    <p>(Бивер чаще всего получал приглашения в последний момент, а то и позже, уже приступая к одинокой трапезе с подноса… «Джон, лапочка, тут вышла неувязка — Соня явилась без Реджи. Будь добр, выручи меня, пожалуйста. Только поторопись, мы уже садимся за стол». Тогда он опрометью кидался за такси и появлялся с извинениями после первой перемены блюд… Одна из его немногих за последнее время, ссор с матерью произошла, когда он таким образом удалился с устроенного ею обеда.)</p>
    <p>— Куда ты поедешь на воскресенье?</p>
    <p>— В Хеттон.</p>
    <p>— А кто там живет? Я что-то забыла.</p>
    <p>— Тони Ласт.</p>
    <p>— Ах да, как же, как же. Она красотка, он зануда. Я и не знала, что ты с ними знаком.</p>
    <p>— Ну, какое там знакомство. Тони пригласил меня вчера вечером у Брэтта. Он мог и забыть.</p>"

let words = System.Text.RegularExpressions.Regex.Matches(txt, "\w+")
type D = delegate of string -> unit
type Prog() =
    let mutable state =
        words
        |> Seq.cast<Match>
        |> Seq.map (fun x -> x.Value)
        |> List.ofSeq |> ListZ.ofList
    let fn = 
        Option.fold (fun _ x -> state <- x; true) false
    let mutable auto = false
    let mutable wait = 500
    let x txb = 
        async {
            do FsharpMyExtension.FSharpExt.until (fun _ -> not <| (auto && ListZ.next state |> fn))
                (fun _ -> txb <| ListZ.hole state; System.Threading.Thread.Sleep wait) ()}
        
    member __.AutoStart (txb:D) =
        auto <- true
        x txb.Invoke |> Async.Start
    member __.AutoStop() =
        if auto then auto <- false else failwith "has stopped"
    member __.Wait with set x = wait <- x and get() = wait
    member __.Next() = ListZ.next state |> fn
    member __.Prev() = ListZ.prev state |> fn
    member __.Current = ListZ.hole state
    member __.Auto = auto
assert
    let p = Prog()
//    p.AutoStart (printfn "%s")
//    p.AutoStop()
    let x = ref true

    //lock x (fun () -> 10)
    true